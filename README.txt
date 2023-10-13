Author : David Pawar
Student id : 0800287
Project : ShawlGalore

2023-10-13 0617 created project as I have created and deleted 3 projects because of error which I could not find.
Yesterday, I made the project but forgot to commit, now gonna create and commit the project,

so previous git repo link https://github.com/david-pawar/ShawlGalore-old-

======================================== previous project's readme ============== current one is after this

Author : David Pawar
Student ID : 0800287
Date : 2023-10-09


     Researching about shawl attributes - visited some websites - amazon.ca, laura.ca, minitipi.ca, lemonwood.ca
     created the project, checked configure for HTTPS option
     created README file
     created Github file, for being set visibility to private for security purposes, before submitting, I will change that visibility to public
  Added a model class, as far I cant see meaning adding that welcome controler and views, created Shawl.cs
  in Shawl.cs, added seven attributes - ID, Material, Color, Design, Occasion, Size, and Product.
  installed Microsoft.EntityFrameworkCore.SqlServer   of framework 3.1.0 

  2023-10-11 1316

  created Data Folder in root directory
  gonna commit all changed now, 
  1321 - added ShawlGaloreContext.cs file in Data folder and updated startup.cs file this code 
                                 using ShawlGallore.Models
                                 using Microsoft.EntityFrameworkCore;
 1325 update public void ConfigureServices(IServiceCollection services) with the code provided in tutorial
 1335 added below code in appsetting.json, got a little confused about server details, do i need to change that because i created a git repo, 
      then thought that, repo is to store the project, but we run the project on local host, so I concluded that there is no need to edit the code
      pasted from tutorial
  
   "ConnectionStrings": {
    "ShawlGaloreContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-1;Trusted_Connection=True;MultipleActiveResultSets=true"
  }

  just to veriy, i ran the project, it is working well so far.

1342  tried scaffolding method to create CRUD pages, got error
"Error : there was an error running the selected code generator: "Package restore  failed, Rolling back  package changes for 'ShawlGalore '""

the first erro, i found in Shawl.cs file, i used double 'll' instead of single 'l' in in ShawlGallore. changed to ShawlGalore
lets pray and redo scafolding

ShawlGaloreContext.cs has the same typo issue

oopss......... still getting the same error
oh same double 'll' error in startup.cs

1358 now installed the latest 3.1.32 version of packages,
1359  oh yessssssssss!!!!!    , code has been generated.
You said once in class, what's an error? it is just simple words, dont panic, I just read the error and calmly thought abour possible 
solutions, 

1403 did initial migration
i wonder why it is written like 20231011180326 if first 8 digits are date last 6 are time, than time is wrong or maybe it according to some
other time standard

1409 researched a little and found timestamp is created according to UTC standards

Now gonna commit and push
read again assignment-1 , now I am going to create aboutus page

created about us page, wrote content in it, but now it is showing page does not found,
just noticed there is lock sign in front oh home and privacy file, but my files has plus sign

1442  see the HomeController.cs file and saw there is IActionResult methods for privacy and index, but i did not created for about us page
  going to create now,

  it worked,

  break time--------

1553 created SeedData.cs in Models
in tutorial, it is shown there are two option in databases when we go through view option, but I am just seeing one.

1620 got the issue core, in appsettings.json when there was MvcMovieContext instead of ShawlGaloreContext.
1627 delete initial migration folder and re did it
1638 restarted process from scafolding as my connection string was wrong.
recreated scafolding and initial migration, and web app is runnng smoothly now

1643 coded SeedData.cs file, added instances of Shawls
 
 --break---
 1738 getting error with using ShawlGalore.Data;, error saying, it does not existing in the namespace 'ShawlGalore'
 I am wondering, I have both (Models and Data) folders in the same directory, why using ShawlGalore.Models; is ok but using ShawlGalore.Data;
 is showing error. they were showing as no needed, so i deleted that

 1801 - unable to view my data

 1839 I wrote ShawlGalore.Models instead of ShawlGalore.Data. Fixed that.




=====================================================================================
=====================================================================================

0623 as i dont think making controller and view part of the tutorial is important for this project, so i am gonna ignore that,

- created Shawl.cs file in Models, copy paste code and than edit it
0627 added attributes, and added image property too, which was missing in previous project 
     installed Microsoft.EntityFrameworkCore.SqlServer of version 3.32
0630 created data folder and added context class
     edited Startup.cs file got error on line 36, did not get before, 
     
   ERROR ===   Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0116	A namespace cannot directly contain members such as fields or methods	ShawlGalore	C:\Users\david\source\repos\ShawlGalore\Startup.cs	36	Active

0638 cause === curly braces misplacement, 
0640 scaffolding step done, without error
0650 i did added image property, but with error i realised I cant add new here, can add but have to delete or change database, so i will add that property
     at the end

everything is working well, I am able to see the table and data 

0701 new added data is not getting added because according to the code if there is any single entry, then dont add new entry, so gonna delete all entries than gonna reenter
0714 added search function in the web app
0717 so far everything is going on smooth thanks  too my previous experience and detailed tutorial.

created a new class ShawlOccasionViewModel in Models folder and added code

0732 got error in searching, web page is not showing

0736 in view/Shawls/Index on line 11 
error = did not edited the code copied from tutorial
