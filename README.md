# EpicGamesStoreNET - .NET Library for Searching the Epic Games Store
[![NuGet](https://img.shields.io/nuget/v/EpicGamesStoreNET.svg)](https://www.nuget.org/packages/EpicGamesStoreNET)

### Overview
This simple library is designed to allow programmers to programmatically search the Epic Games storefront. The response is modeled similar to the response that Epic's GraphQL response returns. Both synchronous and asynchronous query methods exist. This project also contains a test project that you can use as an example of how to use the library.

This is a simple library designed to allow for the creation and accessing of Strawpolls in a really simple fashion. Synchronous and asynchrnous calls are available and all poll details (including vote counts) are returned when creating a new poll or fetching an existing poll.

### Test Project Sample
```
Enter Epic Games Store query:
fort

Search results returned: 1
----------------
Game: Fortnite Battle Royale (categories: games)
Price: 0 (normal: 0)
Link: https://www.epicgames.com/store/en-US/product/fortnite
----------------


Enter Epic Games Store query:
the

Search results returned: 10
----------------
Game: The Outer Worlds (categories: games)
Price: 0 (normal: 0)
Link: https://www.epicgames.com/store/en-US/product/the-outer-worlds/home
----------------
Game: The Sinking City (categories: games)
Price: $59.99 (normal: $59.99)
Link: https://www.epicgames.com/store/en-US/product/the-sinking-city/home
----------------
Game: The Cycle (categories: games)
Price: 0 (normal: 0)
Link: https://www.epicgames.com/store/en-US/product/thecycle/home
----------------
Game: The Jackbox Party Pack (categories: dummy)
Price: $24.99 (normal: $24.99)
Link: https://www.epicgames.com/store/en-US/product/jackbox-party-pack-1
----------------
Game: The Jackbox Games Collection (categories: collections)
Price: no price supplied
Link: https://www.epicgames.com/store/en-US/product/jackbox-collection
----------------
Game: Ancestors: The Humankind Odyssey (categories: games)
Price: 0 (normal: 0)
Link: https://www.epicgames.com/store/en-US/product/ancestors/home
----------------
Game: The Jackbox Party Pack 3 (categories: dummy)
Price: $24.99 (normal: $24.99)
Link: https://www.epicgames.com/store/en-US/product/jackbox-party-pack-3
----------------
Game: The Division 2 (categories: games)
Price: $59.99 (normal: $59.99)
Link: https://www.epicgames.com/store/en-US/product/the-division-2
----------------
Game: The Jackbox Party Pack 5 (categories: dummy)
Price: $29.99 (normal: $29.99)
Link: https://www.epicgames.com/store/en-US/product/jackbox-party-pack-5
----------------
Game: The Witness (categories: freegames, games)
Price: 0 (normal: 0)
Link: https://www.epicgames.com/store/en-US/product/the-witness/home
----------------


Enter Epic Games Store query:
```


### Availability
Available via Nuget: `Install-Package EpicGamesStoreNET`

### Examples and Implementations
- EpicGamesStoreNETTest - This project is included in this repo as a master example project.

### Libraries Utilized
- Newtonsoft.Json - JSON parsing class.  Used to parse responses from Strawpoll API

### Contributors
 * Cole ([@swiftyspiffy](http://twitter.com/swiftyspiffy))
 
### License
MIT License. &copy; 2019 Cole