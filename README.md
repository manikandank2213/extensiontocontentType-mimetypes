# Summary

Most of the time we need mimetype for some process ex:- Creating and writing a content in file as bytes we need mime type.
Here can get mimeType for extension of file you need and can get extension for mimeType of file.

It's developed as console application using C#.

# Usage

# If downloading a whole project

After downloading the project, if you want to check and work with code 
uncomment the **Main** method from **_ExtensionToContentTypeHelper_** class and Run.

you can either choose **Extension to MimeType(ContentType)** or **MimeType(ContentType) to Extension**.

# If you want to add it your project

Get the **_ExtensionToContentTypeHelper_** class file and add it in your project.

**Getting the _MimeType or ContentType_ for extension**

```c#
ExtensionToContentTypeHelper helper = new ExtensionToContentTypeHelper();
string contentType = helper.GetContentTypeByExtension(".pdf");
```

**Getting the _Extension_ for MimeType or ContentType**

```c#
ExtensionToContentTypeHelper helper = new ExtensionToContentTypeHelper();
string contentType = helper.GetExtensionByContentType("application/pdf");
```

**Remove commented main method if you dont want to keep**


# **Additional Tip**
If you dont want to create an instance for this class you can change it to static class and can consume through class name.

```c#
ExtensionToContentTypeHelper.GetContentTypeByExtension(".pdf"); // Extension to Mime Type or ContentType of File
ExtensionToContentTypeHelper.GetExtensionByContentType("application/pdf"); // Mime Type or ContentType to Extension of File
```
