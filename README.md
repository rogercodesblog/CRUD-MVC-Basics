<h1 align="left">CRUD MVC Basics</h1>
<p align="left">This project was built with the intention of showing how to perform a CRUD on a MVC project on .NET.</p>

> [!IMPORTANT]  
> Please note that this project was built with the intention of showing the CRUD fundamentals while working on a MVC project under .NET, so it lacks things that you may find in other program such as pagination, search, filters, authentication, authorization, asynchronous calls and so on.

<p align="left">The application starts with a home page, which shows all the contact entries we have created.</p>

<p align="center">
    <img src="/Screenshots/Home.png">
</p>

<p align="left">In case that we don't have any contact created yet, it shows a message.</p>

<p align="center">
    <img src="/Screenshots/Home-Empty.png">
</p>

<p align="left">By clicking the 'Add new contact' button in the home page, you'll be redirected to a page where you can create one.</p>

<p align="center">
    <img src="/Screenshots/Create.png">
</p>

<p align="left">This forms contains validations that were set on the contact model (./Models/Contact.cs) using Data Annotations.</p>

<p align="center">
    <img src="/Screenshots/Create-Validations.png">
</p>

<p align="left">Once all the inputs meet our desired criteria it will allow us to create a contact.</p>

<p align="center">
    <img src="/Screenshots/Create-Correct.png">
</p>

<p align="left">You can view more details of each contact by clicking on 'Details' button on home page.</p>

<p align="center">
    <img src="/Screenshots/Details.png">
</p>

<p align="left">You can edit them as well.</p>

<p align="center">
    <img src="/Screenshots/Edit.png">
</p>

<p align="left">Contacts can be deleted by clicking on 'Delete' button on home page, once you clicked on it you'll be redirected to 'Delete' page, where you can perform such action.</p>

<p align="center">
    <img src="/Screenshots/Delete.png">
</p>

<p align="left">The 'Detail', 'Edit' and 'Delete' pages make use of an id to retrieve the contact from the database, if the requested contact is not found you'll be redirected to a 'NotFound' page.</p>

<p align="center">
    <img src="/Screenshots/NotFound.png">
</p>
