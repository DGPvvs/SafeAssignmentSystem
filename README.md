# Система  по безопасност за упрявление на  ремонтните наряди
The final project in ASP.NET Course SoftUni



## Цел и предназначение:

Системата има за цел да обезпечава управление и поддържка на електронен дневник, описващ актуалното състояние на технологично оборудване.

## Описание на приложението:

Приложението е изградено като MVC приложение с три слоя:

### SafeAssignmentSystem.DataBase
В този слой се намира модела, описващ базата данни.

Освен структурата описваща вградената система за управление на потребители, поддържана от библиотеката Microsoft.AspNetCore.Identity, са създадени следните таблици описващи останалите компоненти на базата данни:

#### ProductionComplex
Модел на производствените комплекси
#### PlantInstalation
Модел на инсталациите
#### TechnologicalPosition
Модел на технологична позиция
#### WorkingShift
Модел на смените
#### ChangedSchedule
Модел на сменния график
#### SafeAssignmentDocument
Модел на нарядите

### Създадени са и допълнителни таблици
#### ApplicationUser
Наследяващ IdentityUser<Guid> модел добавящ допълнителни данни за потребител

#### ApplicationRole
Наследяващ IdentityRole<Guid> модел съхраняващ данни за ролите

#### ApplicationUserPlantInstalation
Свързваща таблица указваща връзката между потребител и инсталации за които потребителя има права да менажира наряди

В слоя се намира и интерфейсът IRepository деклариращ абстрактни методи за достъп до хранилището на данни - Microsoft SQL Server, както и класа Repository имплементиращ IRepository, внедряващ методите за достъп до хранилището на релационната база данни.
Класът Repository и интерфейсът IRepository са разработени от Стамо Петков и са предоставени от него за ползване от студентите на SoftUni за разработката на учебни WEB проекти.

#### Структура на базата
![image](https://github.com/DGPvvs/SafeAssignmentSystem/assets/94279580/153bab57-1e31-4dca-92b7-0be7381bc876)

### SafeAssignmentSystem.Core (слай с бизнес логика)
В слоя са вградени сървиси и модели с чиято помощ се осъществява обработката на получените от потребителите данни и препращането им към базата данни

#### AccountService
Сървис манипулиращ данните при работа с акаунти на потребители като регистриране на нов потребител, редактиране на данни на съществуващ потребител, промяна на парола и др.

#### ChoisPlantsService
Сървис манипулиращ данните при избор на данни. Включва функционалност за избор на технологични позиции.

#### PlantsService
Сървис манипулиращ с данните при работа с моделите на комплексите, инсталациите и технологичните позиции. Включва функционалности позволяващи създаване на нови комплекси инсталации и технологични позиции, тяхното редактиране и маркиране като изтрити или възстановяване след изтриване на комплекси.

#### WorkingRotationService
Сървис манипулиращ с данните за смените и сменните графици. Включва функционалности позволяващи създаване и редактиране на смени, възможност за редактиране на сменен график на потребител, както и зареждане на месечен сменен график от файл.

#### ReferencesService
Сървис манипулиращ с данните за създаване на отчети. Включва функционалности позволяващи извеждането на справки и отчети.

#### SafeAssignmentService
Сървис манипулиращ с данните при работа с наряди. Включва функционалности позволяващи завеждането, откриването и закриването на наряди. Позволява регистрирането на заявки за подаване на напрежение, както и архивиране на закритите наряди.
