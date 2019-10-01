# DI-InformationModel
Tento projekt je venovaný:
- vytvorenie lokálnej kópie projektu 
- preskúmaniu informačného modelu  _informačného modelu_(IM) založeného na _Device Information Model(DI)_ .
- vytvoreniu vlastného IM.
Predpokladá sa prostredie Windows 7 a vyššie.

## Vytvorenie lokálnej kópie projektu 
Ako prvé je potrebné nainštalovať [git](https://www.develves.net/blogs/asd/articles/using-git-with-powershell-on-windows-10/) do počítača a stiahnuť si dáta z úložiska git. 
Vytvoríme nový adresár c:\informationmodel a vytvoríme klon projektu git [UA ModelCompiler](https://github.com/OPCFoundation/UA-ModelCompiler.git) a [DI-InformationModel
](https://github.com/STUBA-rupr/DI-InformationModel.git) cez prostredie _powershell_:
```
PS C:\> mkdir informationmodel
PS C:\> cd .\informationmodel\
PS C:\informationmodel> git clone https://github.com/OPCFoundation/UA-ModelCompiler.git --recursive
PS C:\informationmodel> git clone https://github.com/STUBA-rupr/DI-InformationModel.git
```
Projekt riešenie _UA-ModelCompiler_ je potrebné skompilovať, odporúčam MS Visual Studiu 2017 Community.

## Vytvorenie vlastného informačného modelu založeného na DI
Návrh informačného modelu váhy založeného na špecifikácii DI: 
![Screenshot](weightScaleIM.png)

Kód ktorý popisuje daný model by mohol vyzerať nasledovne: [modeldesignscale.xml](Published/master/WS/modeldesignscale.xml).

Súbor skompilujeme spustením dávkového súboru:
```
PS C:\informationmodel> cd .\DI-InformationModel\
PS C:\informationmodel\DI-InformationModel> .\PublishModel.bat
Building Model WS
..\UA-ModelCompiler\Bin\debug\Opc.Ua.ModelCompiler.exe   -d2 "Design\modeldesignscale.xml" -cg "Design\modeldesignscale.csv" -o2 "Published\master\WS\"
Trying file: C:\informationmodel\DI-InformationModel\Design\OpcUaDiModel.xml
Trying file: C:\informationmodel\DI-InformationModel\Design\OpcUaDiModel.csv
Copying Model files to Published\master\WS\modeldesignscale
        1 file(s) copied.
        1 file(s) copied.
```

## Preskúmanie informačného modelu _Device Information Model_
Program na vytváranie OPC UA _informačného modelu_ UA Modeler je možné stiahnuť na stránke: [Unified-Automation](https://www.unified-automation.com/products/development-tools/uamodeler.html).
Po spustení programu _UA Modeler_ je treba otvoriť projekt [weightscalenodeset.tt2pro](Published/master/WS/weightscalenodeset.tt2pro). Uzly obsahúce objektové typy DI informačného modelu sú v adresáry Types>ObjectTypes>TopologyElementType. Všetky uzly DI IM sú popísané v špecifikácii [Part 100: Device Information Model](https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-100-device-information-model/). 

Projekt obsahuje aj informačný model pre zariadenie váha:

 ![Screenshot](UAModeler-weightScale.PNG)

## Vytvorenie OPC UA serveru s IM weightScale
Ako prvé je potrebné vytvoriť kópiu OPC UA serveru podľa [návodu](http://opcfoundation.github.io/UA-.NETStandard/help/server_development.htm). **Ale** v našom prípade miesto _Reference Server_ použijeme _Boiler Server_. Upravený projekt je možné stiahnuť z git do nášho koreňového adresára:
```
PS C:\informationmodel> git clone https://github.com/STUBA-rupr/UA-.NETStandard.git
```
Popis zmien sa dá nájsť v [readme-SK.md](https://github.com/STUBA-rupr/UA-.NETStandard/blob/master/SampleApplications/Workshop/Boiler/WeightScaleServer/readme-SK.md#weightscaleserver) súbore. 



