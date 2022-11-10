# World Cup DesktopApp

Windows forms and WPF applications that are sharing the same data layer.
Data layer is using RestSharp to pull and deserialize JSONs to appropriate models. In case of internet connection issues, repository will automatically switch to JSONs that are inside of the project.<br/>

APIs:
<ul>
        <li>http://world-cup-json-2018.herokuapp.com/ for Men World Cup 2018 in Russia</li>
        <li>and http://worldcup.sfg.io/ for Women World Cup 2019 in France.</li> 
</ul>

Applications are saving settings, favorite teams, players and their images for each team. Settings and favorite teams that were chosen on windows forms will be the same on WPF and vice-versa. <br/>

Below you can find short overview of screens in both applications 

## Home screen of windows forms application:
![WindowsFormsHome](https://user-images.githubusercontent.com/81168288/201133740-0167bee8-8755-4fa1-9e45-6dd1bffb2a13.png)

On this form user can select his favorite team, select up to 3 favorite players from the currently selected team. Marking player as favorite can be done by clicking on heart icon or drag and drop action of one or more players. User can also change players image with a click on avatar.

## Statistics screen of windows forms application:
![Statistics](https://user-images.githubusercontent.com/81168288/201134922-2b5bfe13-6435-4cd6-ab82-ee3e27c775be.png)

On this form user can access statistics of individual players and of each match that selected team has played in the tournament.

## Settings screen of windows forms application:
![WindowsFormsSettings](https://user-images.githubusercontent.com/81168288/201136937-53ba2b63-c5c2-4eb1-b5d0-1a893a470beb.png)

Settings screen which enables user to choose between World Cups and set his preferred language

## Home screen of WPF application:
![WPFHome](https://user-images.githubusercontent.com/81168288/201147497-de728ba0-06f7-43f2-b9d1-f1b110b7fa98.png)

Selecting favorite team and his opponent. That action sets the score and first 11 for both teams

## Player card:
![Playericon](https://user-images.githubusercontent.com/81168288/201148626-f9b9fd94-cfa7-419e-9bd0-f0b404c18a4f.png)

Clicking on player opens up his player card with image, number of yellow cards and goals for corresponding match

## Team info:
![TeamStats](https://user-images.githubusercontent.com/81168288/201149028-f00ab56a-1ebd-40c3-b60b-790a204a31d7.png)

Clicking on team info button opens up team statistics for whole tournament
