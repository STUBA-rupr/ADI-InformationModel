# ADI-InformationModel
Tento projekt je venovaný:
- vytvoreniu vlastného informačného modelu založeného na _OPC Unified Architecture for Analyser Devices (ADI)_.
- preskúmaniu informačného modelu ADI.
Predpokladá sa prostredie Windows 7 a vyššie.
## Vytvorenie vlastného informačného modelu založeného na ADI
Ako prvé je potrebné stiahnuť si dáta z úložiska git (git). 
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


## Preskúmanie informačného modelu _OPC UA Analyser Devices (ADI)_
Program na vytváranie OPC UA _informačného modelu_ UA Modeler je možné stiahnuť na stránke: [Unified-Automation](https://www.unified-automation.com/products/development-tools/uamodeler.html).
