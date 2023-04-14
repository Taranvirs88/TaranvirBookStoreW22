﻿2023-03-02
1505
STARATED assignment 2 in class on the lab computer
set up the Asp.net MVC w core 1.3 (out of support)
HTTPS enabled ,individual account authentication no razor 
Reviewed the areas folder, Controller, Model and Views...
AND...
1506....in staratup.cs on the line 33
removed options for default identify
options => options.SignIn.RequireConfirmedAccount = true

1510 Tested the app ...ran it good ...tested links
Action items:
-Modify the navigation
-update the copyright .... from static to dyanmic date.

1514 
update the home page to welcome to TaranvirsBookStore
Tested the app

1516
Default Route pattern

******************
2023-03-03
1510
Continue working on Assignment 2
And clone repository from github through Visual Studio Code 2019
Tested the app 
and commit to github
1523
updated README.md file
Start Working on Assignment 2

2023-03-09
*************
1409
Start Working on Assignment 2
Clone the repository from github 
And start working on using visual studio code

1412
Tested the app it is working good.

1415
Going to Bootswatch.com  and finding the bootstrap templates.
There are many of templates i was puzle but i selected pulse template.
And download the pulse theme bootsrap.css file.

1419
Rename the old bootsrap.css file to bootsrap_old.css

1421
put the download pulse theme bootstrap file into 
wwwroot folder 
this is the path of bootsrap.css file
wwwroot>lib>bootsrap>dist>css>bootstrap.css

1426
 Change the path of bootstrap.min.css  to bootstrap.css 
 <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />

1514
Add some changes in _Layout.cshtml
1.change the nav class navbar light
to navbar dark and bg-white to bg-primary


2.Add addtional properties to  the footer class
@await RenderSectionAsync("Scripts", required: false)


1522
  Remove the text-dark from _LoginPartial.cshtml file.

1542
 add addtional link for css from css text file  in the head tag 

 <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
 *********************
 Also add the addtional script link from text file.
 <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>


Started Working on Assignment 2
****************
Start working on Assignment because i didnot resolve my error becuase project was nort loaded
1745
Added the dropdown navigation bar below the privacy lists the _Layout.cshtml


1900
************************
Open the project  and clone from github and start working on Project added files
Added three class library projects in the solution file project
1.TaranvirsBooks.DataAccess
2.TaranvirsBooks.DataModels
3.taranvirsBooks.Utility

1905
*************
Moved the data folder from the main project into TaranvirsBooks.DataAccess

1915
***********
Delete the migration folder from the Data folder

1920
*************************
Change the namespace Taranvirs.Data to namespace TaranvirsBooks.DataAccess.Data in ApplicationdbContext.cs


1935
********

Rename the Model folder as ViewModels
make some changes in the Homecontroller.cs and Error viewModel.cs

Add SD.cs file in the TaranvirsBooks.Utility folder

Add public static property in SD.cs file in line 47
Add Customer Area Folder 


1945
*******
Move the Homecontrollers.cs File in the Area Folder and change the names on the line 11
 and Update the Startup.cs on the line 64 

1950 
****************
Move the Home folder into the Areas Views Folder 

1952
update the namespace for in HomeControoler.cs

2005
Delete Contoller folder from the TaranvirsBookStore


2023-03-24
*********************
Start working on Assignment 2
Part-2 
clone repository from github 

1514
create the Db 

1517
***********
Update the appsettings.json file on line 3 

1528
*****************
Add migration in the package manager for DataAceess project.
*****************
add-migration AddDefaultIdentityMigration


2023-03-30
**************
Strated Working on Assignment 2
1954

Added the migration file

1956
********************
20230330234509_AddDefaultIdentityMigration.cs
********************
And write command in the PM but it was but it was failed

2007
***********
now update the dabase it is succeed
then Add the Category.cs file into Models folder


2045
**************
Added the new class in the .Models
Category.cs

2050
**********
Added the migration in the PM
add-migration AddCategoryToDb

2053
**********
Update the Database using this command
update-database

New categories are added into the

******************
20230331004_AddCategoryToDb.cs
******************


2153
*************
Created the Repoistory folder in DataAccess project

and 

2155
**********
added a IRepository folder in the Repository folder and write the Crud operations using staraement.

2159
******
Created Category.cs class in the Repsoitory folder
 
And Added the IRepository.cs in the IRepository

2201
*************
Write the methods into ICategoryRepository.cs and call the Methods to…
… CategoryRepository.cs

2023-03-30
*****************
Start again working on Assignment 2
Part2

0112
*********
Created the SP_Call.cs class in the Respoistory folder


0127
**********
Added the UnitOfWork interface in the IRespoistory folder

0234
*********
Added the UnitOfWork class in the Respoistory folder


0240
*********
Created the new CategoryControler.cs in the Area Controller folder

2023-03-31
***************
Rename the UnitOfWork interface to IUnitOfWork

2023-04-06
***************
Start Working on Assignment 2 
Clone the repository and start to execute 
project ran goods


***************
Build the project
(Part 2)
Category CRUD

**************
2023-04-13
1935
*************

And now error is slved and category list is showing

1945
**************
Add category.js inside wwwroot folder.


2010
**************
Modify CategoryController.cs


2023-04-13 
*************
2015
**************
Add _CreateAndBackToListButton.cshtml inside Shared folder

2019
**************
Add  _EditAndBackToListButton.cshtml inside Shared folder

2025
**************
Start Working on Assignment2 
(Part-3)

Created the CoverType.cs class in the TaranvirBooks.Models folder

2320
**************

Add the interface ICoverTypeRepository.cs to the IRepository folder


2323
********************
Created the CoverTypeRepository.cs class in the Repository folder

2328
***********
Call to the CoverTypeRepository.cs class in the UnitOfWork.cs class a… 

… nd in the interface

