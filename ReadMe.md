# StoreClient #

## What is StoreClient? ##
StoreClient is a Portable Class Library that will allow you to acces the data used in the Windows Phone Store app. Allowing you to search for music (albums, artists) and apps. The client also gives you methods for getting the image URLs needed to display the same images that the Store app uses.

## What frameworks are targetted? ##
![Target ALL THE FRAMEWORKS](http://cdn.memegenerator.net/instances/400x/35496697.jpg)
Basically, .NET 4.0+, Windows Phone (7 and 8), Windows Store.

## Installation ##
Installing this can be done through nuget, just use the following command:

`Install-Package StoreClient -pre`

## Usage ##
Usage is very simple and uses the async/await methodology.

A simple search:
`var client = new StoreClient();
var results = await client.SearchAsync("The Dark Knight", includeArtists: false, includeTracks: false);`

Getting an album's image URL:
`var client = new StoreClient();
var url = client.CreateAlbumArtUrl("534be700-0000-0000-0000-000000000000");`

Get an app's icon (the one that appears in the store):
`var client = new StoreClient();
var url = var url = client.CreateAppImageUrl("490f05d0-ee29-4f5f-b5c9-66b48c6f63a2", ImageType.IconLarge);`

## Other notes ##
- If you want, you can pass in your own implementation of an `HttpMessageHandler` when you create your instance of `StoreClient`, however, by default, one is used and has compression turned on.
- You can also change what country the store searches by setting the `Locale` property of `StoreClient`.

