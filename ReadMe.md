# StoreClient #

## What is StoreClient? ##
StoreClient is a Portable Class Library that will allow you to acces the data used in the Windows Phone Store app. Allowing you to search for music (albums, artists) and apps. The client also gives you methods for getting the image URLs needed to display the same images that the Store app uses.

## Licence ##
My own licence for this is use it as much as you want, do what you want. However, at present, it uses the HttpClient package for portable class libraries, which doesn't yet have a Go Live licence, so really, no one can use it in a production app. Please bear this in mind until Microsoft say it's ok.

## What frameworks are targetted? ##
![Target ALL THE FRAMEWORKS](http://cdn.memegenerator.net/instances/400x/35496697.jpg)
Basically, .NET 4.0+, Silverlight 4+, Windows Phone (7 and 8), Windows Store.

## Installation ##
Installing this can be done through nuget, just use the following command:

`Install-Package StoreClient -pre`

## Usage ##
Usage is very simple and uses the async/await methodology.

A simple search:
```c#
var client = new StoreApiClient();
var results = await client.SearchAsync("The Dark Knight", includeArtists: false, includeTracks: false);
```

Getting an album's image URL:
```c#
var client = new StoreApiClient();
var url = client.CreateAlbumArtUrl("534be700-0000-0000-0000-000000000000");
```

Get an app's icon (the one that appears in the store):
```c#
var client = new StoreApiClient();
var url = var url = client.CreateAppImageUrl("490f05d0-ee29-4f5f-b5c9-66b48c6f63a2", ImageType.IconLarge);
```

## Other notes ##
- If you want, you can pass in your own implementation of an `HttpMessageHandler` when you create your instance of `StoreApiClient`, however, by default, one is used and has compression turned on.
- You can also change what country the store searches by setting the `Locale` property of `StoreApiClient`.

## Sample app? ##
Sort of, it doesn't really do much yet though, will build it up a wee bit though.

## Future versions? ##
I hope so. See what the future holds.

## Changelog ##
***0.2.1.0***
- Added the `IStoreApiClient` interface to allow developers to more easily create design time data when using something like MVVM Light.

***0.2.0.0***
Added the following methods:
- `GetAppsListAsync` lets you get a list of apps with different criteria (like, new apps, apps by category etc)
- `GetAppCategoriesAsync` gets the list of all the app categories
- `GetMusicGenresAsync` gets the list of all music genres
- `GetAlbumsByGenreAsync` gets the list of albums for a genre
- `GetArtistsByGenreAsync` gets the list of artists for a genre
- `GetTracksByGenreAsync` gets the list of tracks for a genre based on sort criteria
