# EscapistsMapTools

I wanted to learn to use C# (outside of Unity), so I ported [escapists-map-tools](https://github.com/10se1ucgo/escapists-map-tools) to C#.
The original was pretty garbage, I wrote it as I was learning to program. You'll notice a lot of crappy code in that repo. 
Hopefully the only thing you notice here is my lack of understanding in minor things, such as conventions, Assemblies, ResX, etc.

Anyhow, features:

- Enable editing of a map by decrypting it, setting Info.Custom to -1 and Info.Rdy to 0 and re-encrypting it with a given encryption key

- Decrypt a map with a given encryption key

- Encrypt a map with a given encryption key

# USAGE

1. Download EMT from the `Releases` tab
1. Launch `EMT.exe`
2. Browse for input file
3. Browse for output file
4. Enter encryption key
5. Press one of the buttons.

# LICENSE

```
Copyright 2016 10se1ucgo
https://github.com/10se1ucgo/

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```
