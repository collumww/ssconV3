# ssconV3
sscon - a console companion to ss

See ssV3 for more complete informataion on ss and sscon. 

sscon would be used something like this at a powershell prompt:

get-content editcommands.txt | sscon xxx.txt, yyy.txt, *.ps1

This will:

1) run the editor
2) open xxx.txt, etc
3) run the ss commands inside editcommands.txt as if they were typed in 


