# _Number Counter_

#### _A counter to count the number of word occurances, October 4th, 2019_

#### _By **Jennifer Batara**_

## Description

This application is a C#.Net application run in the console that takes in a user input and replies back with a report on how often each unique word is written in the input.

## Specifications: Repeat Counter

|Spec | Input | Output|
|:---:|:------|:------|
|CreateList function will create a list of strings that break words up based on spaces and new lines.|This is an examples of a valid input. <br> It even takes things like extra character$.| new List<string>() {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."}|
|CleanList will create a new list of strings that strips capitol letters and end line "."|new List<string>() {"This", "is", "an","example","of","a","valid","input.", "It", "even", "takes", "things", "like", "extra", "character$."}|new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even", "takes", "things", "like", "extra", "character$"}|
|UniqueValues will take in a string and return a list of the unique values. |new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even", "will", "take", "a", "few","things", "like", "extra", "character$"}| new List<string>() {"this", "is", "an","example","of","a","valid","input", "it", "even","will", "take","few", "things", "like", "extra", "character$"}|
|CountOccurrances will take in a string and return a dictionary with each word as the key and the number of occurances as the value|This is an examples of a valid input. <br> It even takes things like extra character$.| new Dictionar<string,int>(){{"this", 1},{"is",1},{"an", 1},{"example",1},{"of",1},{"a",1},{"valid",1},{"input",1},{"it",1},{"even",1},{"takes",1},{"things",1},{"like", 1},{"extra",1},{"character$",1}}|

## Specifications: User Interface

|Spec | Input | Output|
|:---:|:------|:------|




## Setup/Installation Requirements

-   Internet Connection
-   Internet browser
-   Bash Terminal
-   .NET Core

If you do not have the .NET Core installed on your computer, please install it by following the directions for your operating system [here](https://dotnet.microsoft.com/download). The .NET Core version used for this project is 2.1

To view locally please copy the link to [this repo](https://github.com/jbatara/WordCounter) and type the following command into your Bash terminal:
```
$git clone repo_url
```

with repo_url being the url that was just copied. To open the console app, navigate to the local directory which the online repository was cloned to using the command

```
$cd CarbsTheBakery/
```

Once in the correct repository, and confirming that you have .NET core installed (version 2.1 at minimum), run the app with the command
```
$dotnet run
```
and enjoy!

This project is currently not hosted online.

## Known Bugs

_No bugs have been reported_

## Support and contact details

Please feel free to contact the developer by raising a new [issue](https://github.com/jbatara/WordCounter/issues/new) on the github repo. You can browse the current issues [here](https://github.com/jbatara/WordCounter/issues).

## Technologies Used

* C#
* .NET Core 2.1

## Design Considerations

- Followed the "Red, Green, Refactor" workflow

### License

_MIT_

Copyright (c) 2019 **_Jennifer Batara_**