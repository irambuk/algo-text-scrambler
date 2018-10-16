## Text Scrambler
### Overview
The algorithm performs
- scrambles text
- keep the input and output text lengths are same
- ability to pass a seed
- same scrambled text for same input text and seed
- ability to skip scrambling of certain special characters

### Algorithm


### Sample Output
Seed text: 'This is a seed'  
Seed integer: 3433  
Scramble skip chars: space, $  
Scramble output chars: abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ 

|Text|Text-Length|Scrambled Text|Scrambled Text-Length|
|-----------|-----------|-----------|-----------|
|test|4|DnFx|4|
|sample|6|Txh6xP|6|
|test sample|11|DnFx h6HPLH|11|
|sample test|11|Txh6xP t6f0|11|
|asdf sample test 323423 @#$#@dfsd df|36|jVNd h6HPLH FdHz HJznDb vb$tlfX6J pt|36|
|teetw sdfds.dsf sfdfsdf #@#$32 sdfsf fdsfs|42|DnVxH xhzxvn2Xn PZbRNnD TdR$nF 6JlNt 2J0Fd|42|

### Possible Improvements

