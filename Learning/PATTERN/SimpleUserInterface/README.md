## This is Simple MVP pattern

-- it has no DB
-- aims to understand the usage of interface better
-- displays specific page with MVP pattern

-- although it has Models here, it is not being utilize just yet, together with _Repository.
-- since My goal here is to understand Interface better and implement it on my other apps in the future

-- Simple Diagram generated with AI

flowchart TD

    %% Program Entry
    A[Program.cs] -->|creates| B[MainView : Form]
    A -->|creates| C[MainPresenter]

    %% MainView & Interface
    B --- IMain[<<interface>> IMainView]
    IMain -->|implemented by| B
    B -->|raises event ShowPetView| C

    %% MainPresenter
    C -->|creates| D[PetView : Form]
    C -->|creates| E[PetPresenter]

    %% PetView & Interface
    D --- IPet[<<interface>> IPetView]
    IPet -->|implemented by| D
    D -->|raises CRUD events| E

    %% PetPresenter & Repo
    E --- IRepo[<<interface>> IPetRepository]
    IRepo -->|implemented by| F[PetRepository]

    %% Repository & DB
    F --> G[(SQL Database : Pet table)]



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