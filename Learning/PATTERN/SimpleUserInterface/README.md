## This is Simple MVP pattern

-- it has no DB
-- aims to understand the usage of interface better
-- displays specific page with MVP pattern

-- although it has Models here, it is not being utilize just yet, together with _Repository.
-- since My goal here is to understand Interface better and implement it on my other apps in the future

-- Simple Diagram generated with AI

flowchart TD

+----------------------+
|      Program.cs      |
|  - Entry point       |
|  - Reads config      |
|  - Creates MainView  |
|  - Creates MainPresenter
+----------------------+
            |
            v
+---------------------------+       implements        +----------------------+
|        MainView           | <---------------------> |      IMainView       |
| (Windows Form, UI)        |                        | - event ShowPetView   |
| - btnPet.Click → raises   |                        | - event ShowOwnerView |
|   ShowPetView             |                        | - event ShowVetsView  |
+---------------------------+                        +----------------------+
            |                                                      
 raises event |                                                      
            v                                                       
+---------------------------+                                       
|      MainPresenter        |                                       
| - ctor(IMainView, connStr)|                                       
| - subscribes to ShowPetView                                       
| - creates PetView & PetPresenter                                  
+---------------------------+                                       
            | creates                                           
            v                                                      
+---------------------------+        implements       +----------------------+
|         PetView           | <---------------------> |      IPetView        |
| (UI Form for pets)        |                        | - PetId, PetName,... |
| - Raises SearchEvent, etc.|                        | - events: Add, Edit, |
| - Displays Pet list grid  |                        |   Delete, Save, ...  |
+---------------------------+                        +----------------------+
            |                                                      
 raises events |                                                      
            v                                                       
+---------------------------+                                       
|       PetPresenter        |                                       
| - ctor(IPetView, IPetRepo)|                                       
| - Handles events from view|                                       
| - Calls PetRepository     |                                       
| - Updates BindingSource   |                                       
+---------------------------+                                       
            |                                                       
 calls repository |                                                       
            v                                                       
+---------------------------+        implements       +----------------------+
|     PetRepository         | <---------------------> |   IPetRepository    |
| - Add, Edit, Delete, Get  |                        | (CRUD definitions)   |
| - Talks to SQL DB         |                        |                      |
+---------------------------+                        +----------------------+
            |
            v
+---------------------------+
|         Database          |
|  (SQL Server, Pet table)  |
+---------------------------+



🔑 Breakdown with Interfaces

#IMainView
-Declares navigation events (ShowPetView, ShowOwnerView, ShowVetsView).
-Implemented by MainView.

#MainPresenter
-Works only with IMainView (not concrete MainView).
-Subscribes to ShowPetView → creates PetPresenter.

#IPetView
-Declares pet properties, events (SearchEvent, AddNewEvent, etc.).
-Implemented by PetView.

#PetPresenter
-Depends on IPetView + IPetRepository.
-Acts as the middleman between UI and data.

#IPetRepository
-Declares CRUD methods.
-Implemented by PetRepository.

#PetRepository
-Actual SQL operations → DB.