#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -fsSL -o openapi.yaml https://docs.resemble.ai/openapi.json
autosdk generate openapi.yaml \
  --namespace ResembleAI \
  --clientClassName ResembleAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
