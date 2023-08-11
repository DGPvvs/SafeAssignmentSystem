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
Сървис манипулиращ данните при избор. Включва функционалност за избор на технологични позиции.

#### PlantsService
Сървис манипулиращ с данните при работа с моделите на комплексите, инсталациите и технологичните позиции. Включва функционалности позволяващи създаване на нови комплекси инсталации и технологични позиции, тяхното редактиране и маркиране като изтрити или възстановяване след изтриване на комплекси.

#### WorkingRotationService
Сървис манипулиращ с данните за смените и сменните графици. Включва функционалности позволяващи създаване и редактиране на смени, възможност за редактиране на сменен график на потребител, както и зареждане на месечен сменен график от файл.

#### ReferencesService
Сървис манипулиращ с данните за създаване на отчети. Включва функционалности позволяващи извеждането на справки и отчети.

#### SafeAssignmentService
Сървис манипулиращ с данните при работа с наряди. Включва функционалности позволяващи завеждането, откриването и закриването на наряди. Позволява регистрирането на заявки за подаване на напрежение, както и архивиране на закритите наряди.


### SafeAssignmentSystem (WEB слой)
В слоя се намират контролерите, визуалните модели и изгледите, позволяващи комуникацията между сървъра и клиентите (потребителите на приложението).

Разработени са следните контролери:

#### AccountController
Контролер управляващ визуализирането и получаването на данните касаещи работата с акаунти.

#### ChoicesController
Контролер управляващ визуализирането и получаването на данни при извършване на избор.

#### PlantsController
Контролер управляващ визуализирането и получаването на данни при обработката на данни свързани с производствените комплекси, инсталациите и технологичните позиции. 

#### ReferenceController
Контролер управляващ визуализирането и получаването на данни при създаването на отчети и справки. 

#### SafeAssignmentController
Контролер управляващ визуализирането и получаването на данни при създаването и менажирането на наряди.

#### WorkingRotationController
Контролер управляващ визуализирането и получаването на данни при менажирането на смени и сменни графици.

В логиката на приложението са включени три основни роли – Администратор, Оператор и Дежурен електротехник. Всяка роля има строго определени функционалности и ограничения. Регистриран потребител в даден момент може да приема само една от посочените роли.

#### Роля Администратор
 Права:
-	неограничен достъп до системата;
-	промяна на лична парола;
-	манипулации с акаунти - регистрация на нов потребител, редактиране на данни на вече регистриран потребител, задаване на роли на регистриран потребител, задаване на нова парола на регистриран потребител;
-	манипулации с данни за комплекси, инсталации и технологични позиции – създаване, и редакция;
-	манипулация на данни за работни смени и сменни графици – създаване на нови и редактиране на вече създадени смени и сменни графици;
-	изготвяне на справки за всички инсталации и технологични позиции.

  
Ограничения: 
-	няма права да менажира наряди;
-	няма права да редактира данни за собственият си акаунт.

#### Роля Оператор
Права:
-	може да достъпва системата само ако е включен в сменният график за текущата дата и час;
-	промяна на лична парола;
-	завежда нови наряди за технологични позиции в инсталациите за които има права
-	прави заявки за подаване на напрежение за технологични позиции в инсталациите за които има права, при условие, че за конкретната технологична позиция към момента на подаване на заявката няма действащи наряди;
-	изготвяне на справки за технологичните позиции в инсталациите за които има права.

  
Ограничения:
-	няма права за всички дейности, които могат да се извършват от потребители с роля Администратор и Дежурен електротехник.

#### Роля Дежурен електротехник
Права:
-	може да достъпва системата само ако е включен в сменният график за текущата дата и час;
-	промяна на лична парола;
-	открива заведени наряди за технологични позиции в инсталациите за които има права
-	закрива открити наряди за технологични позиции в инсталациите за които има права
-	отчита подаването на напрежение за технологични позиции в инсталациите за които има права, при условие, че за конкретната технологична позиция към момента на подаване на заявката няма действащи наряди и има подадена заявка;
-	изготвяне на справки за технологичните позиции в инсталациите за които има права.

  
Ограничения:
-	няма права за всички дейности, които могат да се извършват от потребители с роля Администратор и Оператор

#### Роля NoRole
С цел коректното извеждане на архивни данни е въведена и четвърта роля, давана на регистрирани потребители, които вече нямат права за посочените три роли. Потребителите с тази роля нямат право да достъпват системата.

### Тестови данни
За провеждане на тестове в базата данни са регистрирани потребители със следните роли:

Администратор - потребителско име: Zahari.Todeev и парола Aa123456

Оператор - потребителско име: Lazo.Chichmanov и парола Aa123456

Дежурен електротехник - потребителско име: Rusi.Magitchov и парола Aa123456


За улеснение на тестването в базата е регистрирана смяна ALL, а в сменният график на тестовия Оператор и Дежурен електротехник е въведена смяна, която не зависи от конкретна дата и час.
За демонстриране на възможностите за зареждане на сменен график от файл е предоставен тесторият файл SafeAssignmentSystem/wwwroot/Пробен график за септември 2023.xlsx.
