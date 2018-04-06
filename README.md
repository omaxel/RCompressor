<img src="http://raw.github.com/OmarMuscatello/RCompressor/master/rcompressor.png" height="70" alt="RCompressor">

A compressor for Razor Views.

**Help me!** Improve this translation with a pull request.

#### [Download latest version](https://github.com/OmarMuscatello/RCompressor/archive/v1.0.zip) 
or see [previous versions](https://github.com/OmarMuscatello/RCompressor/releases).

##### Summary
- [Introduction](#introduction)
- [How to use](#how-to-use)
  - [Command line usage](#command-line-usage)

## Introduction
Have you ever thought that the generated HTML from a .cshtml fileis not optimized?

Take a look at the below code which is the content of a simple `_Layout.cshtml` file:

```
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - WebApplication6</title>
</head>
<body>
    <div>
        @RenderBody()
        <footer>MyWebApplication</footer>
    </div>
    @RenderSection("Scripts", required: false)
</body>
</html>
```

And the below code is the content of a simple `Index.cshtml` file:

```
@{
    ViewData["Title"] = "Home Page";
}
<div class="row">
    <h1>This the Index page</h1>
</div>
```

When you visit the page through the browser, the generated HTML is:

```
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Home Page - WebApplication6</title>
</head>
<body>
    <div>
        <div class="row">
    <h1>This the Index page</h1>
</div>
        <footer>MyWebApplication</footer>
    </div>
    
</body>
</html>
```

How many spaces and empty new lines!

The response size is 650B. Of course this is not a problem if the page is very small, but think about larger pages whose size is near 3MB.

Using **RCompressor** you can strip out the code from spaces, empty lines and comments.

Processing the previous .cshtml files with **RCompressor** the response size becomes 604B, which is smaller than ~8%. Think how many bytes can you save in bigger view files.

## How to use
- [Download]() the latest version of **RCompressor** and launch it;
- paste the directory/file path in the first field;
- check the *Scan subfolders* option if required;
- press the *Compress* button.

#### Command line usage
You can use **RCompressor** using the command line by passing the paths as parameters.

Add the `-subfolders` option to scan subfolders.

**Usage example:** 
```
> RCompressor.exe -subfolders "C:\MyDir" "C:\MyFile.cshtml"
```

**RCompressor** will compress all .cshtml files inside `C:\MyDir` and subfolders. It will also compress the `C:\MyFile.cshtml` file.