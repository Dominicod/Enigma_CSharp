<p align="center">
  <img src="https://blog.dominwrites.com/wp-content/uploads/2022/07/cropped-cropped-cropped-D-1.png" />
</p>
<center><h1>About</h1></center>
<center>This application is a basic caesar cypher that shifts the letters of a string/text by a certain desired amount.</center>
<center><h1>Info</h1></center>
 This is a super basic application that I created to better understand the basic workings of C#. There is many flaws such as, code can be DRYer, Better OOP usage, More Complex, and overall better usage of the language.

However for spending a bit over the weekend to come to some understanding of the language, I am fairly happy and proud of it.

<h2>How to use the application</h2>

- Clone this repo
- Install .NET Core (This application is running 7.0.100)
- `dotnet run`

After `dotnet run` is sent through the console, you will be prompted with a question, reply correctly and you will move onto the next prompt, asking for a message, and key.

Example Encryption:

```bash
Would you like to encrypt(0) a message, or decrypt(1) a message:
0
Please enter a message(string), followed by a key(number):
test 1
Encrypted Message: uftu, Original Message: test
```

Example Decryption:

```bash
Would you like to encrypt(0) a message, or decrypt(1) a message:
1
Please enter the encrypted message(string), followed by the key used(number):
uftu 1
Encrypted Message: uftu, Original Message: test
```

The application does handle basic error handling, if you have incorrectly entered an argument, you will be promptly yelled at;

`Error: Incorrect arguments sent`

## Contributions
<a href="https://github.com/Dominicod/rails-engine-lite/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=Dominicod/rails-engine-lite" />
</a>
<p>🔥 Github: <a href="https://github.com/Dominicod">https://github.com/Dominicod</a> LinkedIn: <a href="https://www.linkedin.com/in/dominic-odonnell/">https://www.linkedin.com/in/dominic-odonnell/</a>  </p>


