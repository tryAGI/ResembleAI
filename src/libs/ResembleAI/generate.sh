#!/usr/bin/env bash
set -euo pipefail

spec_url="https://docs.resemble.ai/openapi.json"
temp_spec="$(mktemp)"

cleanup() {
  rm -f "$temp_spec"
}

trap cleanup EXIT

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

if curl -fsSL -o "$temp_spec" "$spec_url"; then
  mv "$temp_spec" openapi.yaml
elif [[ ! -f openapi.yaml ]]; then
  echo "Failed to download $spec_url and no checked-in openapi.yaml exists." >&2
  exit 1
else
  echo "Warning: $spec_url is unavailable; reusing the checked-in openapi.yaml." >&2
fi

./normalize-openapi.sh openapi.yaml

autosdk generate openapi.yaml \
  --namespace ResembleAI \
  --clientClassName ResembleAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

./postprocess-generated.sh Generated
