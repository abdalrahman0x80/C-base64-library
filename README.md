# C-base64-library
discription : Encoding And Decoding Base64 Text Very Simple by this Library use this lib Now

# how to use ?

1. move this file to your folder project 
2. open your project
3. write : ``` using Base64 ```
----
# example

```csharp
using Base64;
using System;
namespace Project{
  class App(){
    public static void Main(){
     //encodde
     EncodingAndDecoding base64 = new EncodingAndDecoding();
     var encode = base64.encode("hello world");
     var decode = base64.decode("Note : here write base64 Text !")
     Console.WriteLine("enc : " + encode);
     Console.WriteLine("dec : " + decode);
    
    }


   }


}
```
