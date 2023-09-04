# BSA 2023 | .NET | LeetWars

**Technologies:**

Backend:

- Platform: .NET 6
- Network: REST, SignalR, RabbitMQ
- Database: MS SQL Server, Entity Framework Core
- Cloud: Azure
- Other: JWT, Firebase, Docker

Frontend:

- Angular
- HTML5/CSS3/SASS

## Links:

- [Website]()
- [Trello Board](https://trello.com/b/vd3GZpS8/leetwars)

## Building sources

By default, apps run on the following ports:

| Application           | Port |
| --------------------- | ---- |
| LeetWars.**Core**     | 5050 |
| LeetWars.**Notifier** | 5070 |
| LeetWars.**Emailer**  | 5080 |
| LeetWars.**Builder**  | 5090 |
| RabbitMQ              | 5672 |

_Tip: If you want to connect to the specific service outside of docker, then use "localhost" as a service name, but if both services are inside docker, use service_name from a "docker-compose" file instead._

## DB Schema

```mermaid
erDiagram
    %%Main
    Users{
        id bigint PK
        country int
        timezone int
        sex int
        status int
        birthDate datetime
        firstName nvarchar
        lastName nvarchar
        userName nvarchar
        email nvarchar
        imagePath nvarchar
        totalScore bigint
        registeredAt datetime
        oathToken nvarchar
        isSubscribed boolean
        isBanned boolean
    }
    Users ||--o{ Challenges : authors_of
    Users ||--o{ UserSolutions : authors_of
    Users ||--o{ UsersPreferredLanguages : users
    Users ||--o{ UsersLanguagesLevels : users

    Challenges {
        id bigint PK
        authorId bigint FK
        title nvarchar
        instructions string
        levelId int FK
        createdAt datetime
    }
    Challenges ||--o{ ChallengeVersions : challenge_versions
    Challenges ||--o{ ChallengeTags : challenge

    ChallengeVersions{
        id bigint PK
        languageId int FK
        challengeId bigint FK
        initialSolution string
        completeSolution string
        status int
        createdAt datetime
    }
    ChallengeVersions ||--o{ ChallengeVersionLanguageVersions : challenge_version
    ChallengeVersions ||--o{ UserSolutions : challenge_version_solutions
    ChallengeVersions ||--o{ Tests : tests

    UserSolutions{
        id bigint PK
        userId bigint FK
        challengeVersionId bigint FK
        code string
        output string
        submittedAt nullable_datetime
        createdAt datetime
    }

    Tests{
        id bigint PK
        challengeVersionId bigint FK
        code string
        isPublic bool
        createdAt datetime
    }

    Subscriptions{
        id bigint PK
        userId bigint FK
        paymentSubscriptionId nvarchar
        typeId int FK
        cost decimal
        startDate datetime
        endDate datetime
        subscribedDate datetime
        unsubscribedDate nullable_datetime
        isActive boolean
    }
    Subscriptions }o--|| Users : users_subscription

    %%Secondary
    SubscriptionTypes{
        id int PK
        name nvarchar
        description nvarchar
        cost decimal
        billingPeriod int
    }
    SubscriptionTypes ||--o{ Subscriptions : subscription_type

    Tags{
        id int PK
        name nvarchar
    }
    Tags ||--o{ ChallengeTags : tag

    Languages {
        id int PK
        name nvarchar
    }
    Languages ||--o{ ChallengeVersions : version_language
    Languages ||--o{ UsersPreferredLanguages : languages
    Languages ||--o{ UsersLanguagesLevels : languages
    Languages ||--o{ LanguageVersions : language

    LanguageVersions {
        id int PK
        languageId int FK
        version nvarchar
    }
    LanguageVersions ||--o{ ChallengeVersionLanguageVersions : language_version

    ChallengeLevels{
        id int PK
        name nvarchar
        reward int
    }
    ChallengeLevels ||--o{ Challenges : levels

    %%Junction
    ChallengeTags{
        challengeId bigint PK
        tagId int PK
    }

    UsersLanguagesLevels{
        userId bigint PK
        languageId int PK
        languageLevel int
    }

    UsersPreferredLanguages{
        userId bigint PK
        languageId int PK
    }

    ChallengeVersionLanguageVersions{
        challengeVersionId bigint PK
        languageVersionId bigint PK
    }
```

## Code quality

Make sure you read and follow [.NET Quality Criteria](https://github.com/BinaryStudioAcademy/quality-criteria/blob/production/src/dotnet.md).
Also, there are some best practices for frontend development: [Angular](https://angular.io/guide/styleguide) and [Typescript](https://google.github.io/styleguide/tsguide.html)

#### Docker:

1. Make sure you have [Docker](https://www.docker.com) and [Docker Compose](https://docs.docker.com/compose/install).
2. Pull this repo to your machine.
3. You can build and run all application containers via `docker-compose -f docker-compose.apps.yml up -d` command.
4. You can pull and run all 3rd-party services (MSSQL Server, RabbitMQ) via `docker-compose -f docker-compose.services.yml up -d` command.
5. Happy coding! :sunglasses:

#### Setup environment for local development:

1. Download and install [.NET 6 SDK](https://dotnet.microsoft.com/download).
2. It might be useful to have EF CLI. Install via command: _dotnet tool install --global dotnet-ef_
3. Download and install LTS version of [Node.js](https://nodejs.org/en/)
4. Install Angular-CLI via: _npm install -g @angular/cli_. _[What is Angular-CLI?](https://angular.io/cli)_

## Extensions for frontend development (required):

- ESLint (analysis tool that checks TypeScript\JavaScript code for readability, maintainability, and functionality errors)
- EditorConfig (helps maintain consistent coding styles for multiple developers working on the same project)

Some extra extensions which can significantly help to work with Angular:

- Angular Language Service (intelliSense for Angular templates)
- Angular Snippets
- Angular Schematics (working with Angular schematics via UI)

## Environment variables

This is a list of the required environment variables:

#### RabbitMQ

**RABBIT_MQ_USERNAME** - RabbitMQ username

**RABBIT_MQ_PASSWORD** - RabbitMQ user password

#### MSSQL Server

**SA_PASSWORD** - MSSQL Server "SA" user password
