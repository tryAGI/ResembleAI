#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

spec_url="https://docs.resemble.ai/openapi.json"
temp_spec="$(mktemp)"

cleanup() {
  rm -f "$temp_spec"
}

trap cleanup EXIT
install_autosdk_cli

if fetch_spec -fsSL -o "$temp_spec" "$spec_url"; then
  if jq -e '.paths | has("/synthesize") and has("/stream") and has("/voices")' "$temp_spec" >/dev/null; then
    mv "$temp_spec" openapi.yaml
  else
    echo "Warning: required synthesis and voice endpoints disappeared from $spec_url; reusing checked-in spec." >&2
  fi
elif [[ ! -f openapi.yaml ]]; then
  echo "Failed to download $spec_url and no checked-in openapi.yaml exists." >&2
  exit 1
else
  echo "Warning: $spec_url is unavailable; reusing the checked-in openapi.yaml." >&2
fi

./normalize-openapi.sh openapi.yaml

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace ResembleAI \
  --clientClassName ResembleAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --strip-redundant-operation-id-tag-prefixes \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

./postprocess-generated.sh Generated
