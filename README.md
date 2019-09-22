# DI-InformationModel
Tento projekt je venovaný:
- vytvorenie lokálnej kópie projektu 
- preskúmaniu informačného modelu  _informačného modelu_(IM) založeného na _Device Information Model(DI)_ .
- vytvoreniu vlastného IM.
Predpokladá sa prostredie Windows 7 a vyššie.

## Vytvorenie lokálnej kópie projektu 
Ako prvé je potrebné nainštalovať [git](https://www.develves.net/blogs/asd/articles/using-git-with-powershell-on-windows-10/) do počítača a stiahnuť si dáta z úložiska git. 
Vytvoríme nový adresár c:\informationmodel a vytvoríme klon projektu git [UA ModelCompiler](https://github.com/STUBA-rupr/UA-ModelCompiler) cez prostredie _powershell_:
```
PS C:\> mkdir informationmodel
PS C:\> cd .\informationmodel\
PS C:\informationmodel> git clone https://github.com/STUBA-rupr/UA-ModelCompiler --recursive
```
Projekt riešenie UA-ModelCompiler odporúčam skompilovať v MS Visual Studiu 2017 Community.
Vytvoríme adresár **scaledevicemodel** a skopírujeme potrebné súbory.

```
mkdir scaledevicemodel
cp .\UA-ModelCompiler\Published\ADI\OpcUaAdiModel.xml .\scaledevicemodel\
```

## Vytvorenie vlastného informačného modelu založeného na DI
Návrh informačného modelu váhy založeného na špecifikácii DI: 
![Screenshot](weightScaleIM.png)

Kód ktorý popisuje daný model by mohol vyzerať nasledovne: [modeldesignscale.xml](Published/master/WS/modeldesignscale.xml).


## Preskúmanie informačného modelu _Device Information Model _
Program na vytváranie OPC UA _informačného modelu_ UA Modeler je možné stiahnuť na stránke: [Unified-Automation](https://www.unified-automation.com/products/development-tools/uamodeler.html).
Po spustení programu _UA Modeler_ je treba otvoriť projekt **weightscalenodeset.tt2pro**. Uzly obsahúce objektové typy DI informačného modelu sú v adresáry Types>ObjectTypes>TopologyElementType. Všetky uzly DI IM sú popísané v špecifikácii [Part 100: Device Information Model](https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-100-device-information-model/).
