<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/vikinatora/Smart-Strength-Backend">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Smart Strength Backend</h3>

  <p align="center">
    .NET Core API for Smart Strength project.
    <br />
    <a href="https://github.com/vikinatora/Smart-Strength-Backend"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/vikinatora/Smart-Strength-Backend">View Demo</a>
    ·
    <a href="https://github.com/vikinatora/Smart-Strength-Backend/issues">Report Bug</a>
    ·
    <a href="https://github.com/vikinatora/Smart-Strength-Backend/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
<details open="open">
  <summary><h2 style="display: inline-block">Table of Contents</h2></summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This application started as a university project for the Software Technologies course in TU-Sofia. Our team had to come up with an interesting idea that is bussiness 
viable and hasn't been implemented before, write [architecure and project documents](https://github.com/vikinatora/Smart-Strength-Backend/tree/main/Documentations), 
implement the applicaiton, test it and present it. 

As everybody from our team worked out I came up with the idea of an application which after a series of questions, uses science based expert system to create a workout 
plan and diet regime which meets the user's needs. Using the application users can keep track of their progress using a workout log and ocassionally share their 
workout achievements mid training which creates the social media twist of the app.

I think this concept really makes the application stand out. And it kinda worked... If it wasn't for the deadlines we had to meet the project could have been implemented much better.
That's why there's [Smart Strength V2](https://github.com/smart-strength) in the making. 

### Built With

* [.NET CORE](https://dotnet.microsoft.com/download)
* [Firebase](https://firebase.google.com/)


<!-- GETTING STARTED -->
## Getting Started

### Prerequisites
* Set up [Firebase project](https://console.firebase.google.com/u/0/)
* [Follow this guide](https://firebase.google.com/docs/firestore/quickstart#c)


### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/vikinatora/Smart-Strength-Backend.git
   ```
2. Set your projet name in FirebaseService.cs
   ```sh
   this.FirestoreDb = FirestoreDb.Create("{Your firebase project name}");
   ```
3. Get your project's API json credentials from [here](https://console.cloud.google.com/projectselector2/apis/credentials)  
4. Paste the file somewhere in your project's directory
5.  Go to project's properties -> Debug -> Add Key: GOOGLE_APPLICATION_CREDENTIALS and Value: {Path to your json file}
6. Install Conveyor by Keyoti extensions (Any other tool that can convert your localhost URL to Remote access URL also works)
7. Start the project
8. Copy the remote url and paste in the client
9. [Client set up steps here](https://github.com/vikinatora/smart-strength-client)
   
<!-- USAGE EXAMPLES -->
## Usage

<b>Start this project. Start the client side project. Enjoy! :)</b>

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/vikinatora/Smart-Strength-Backend/issues) for a list of proposed features (and known issues).

This project has been canceled as it started as a university project. This meant that the tech stack had to relatively simple in order to make it possibble for my team memmbers to collaborate, didn't expoect to do most of the work myself,
had to meet deadlines which combined led to poor design and architecture decision. After presenting the project I decided the code is bad and isn't worth refactoring but 
I really liked the idea of the app and now [Smart Strength V2](https://github.com/smart-strength) is in progress. 


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

This repo isn't maintained anymore.

If you like the idea please contribute to [Smart Strength V2](https://github.com/smart-strength) or contact me directly.

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Viktor Todorov - vikktoort@gmail.com

Project Link: [https://github.com/vikinatora/Smart-Strength-Backend](https://github.com/vikinatora/Smart-Strength-Backend)



[contributors-shield]: https://img.shields.io/github/contributors/vikinatora/Smart-Strength-Backend.svg?style=for-the-badge
[contributors-url]: https://github.com/vikinatora/Smart-Strength-Backend/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/vikinatora/Smart-Strength-Backend.svg?style=for-the-badge
[forks-url]: https://github.com/vikinatora/Smart-Strength-Backend/network/members
[stars-shield]: https://img.shields.io/github/stars/vikinatora/Smart-Strength-Backend.svg?style=for-the-badge
[stars-url]: https://github.com/vikinatora/Smart-Strength-Backend/stargazers
[issues-shield]: https://img.shields.io/github/issues/vikinatora/Smart-Strength-Backend.svg?style=for-the-badge
[issues-url]: https://github.com/vikinatora/Smart-Strength-Backend/issues
[license-shield]: https://img.shields.io/github/license/vikinatora/Smart-Strength-Backend.svg?style=for-the-badge
[license-url]: https://github.com/vikinatora/Smart-Strength-Backend/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/viktor-todorov-8a7434122

