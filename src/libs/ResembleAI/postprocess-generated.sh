#!/usr/bin/env bash
set -euo pipefail

generated_dir="${1:-Generated}"

find "$generated_dir" -name '*.g.cs' -print0 |
  while IFS= read -r -d '' file; do
    perl -0pi -e '
      s/HttpClient\.BaseAddress \?\?= baseUri \?\? new global::System\.Uri\(DefaultBaseUrl\);/if (baseUri is not null)\n            {\n                HttpClient.BaseAddress ??= baseUri;\n            }/g
    ' "$file"
  done
