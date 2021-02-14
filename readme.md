# RandomProductView controls

RandomProductView is a custom control for Windows Forms to show random products from the AdventureWorks2016 data base.

### Installation
> **1.** Right-click on toolbox
> **2.** Select "Choose Items"
> **3.** Browse to your DLL.
> **4.** Add the items


### Usage
You can add the control to your form using the designer, selecting the control drom the tolbox and dragi'n in it to the form or you can add it from the code like this:
```csharp
RandomProductView.RandomProductView randomProductView2 = new RandomProductView.RandomProductView();
// Set the connection string
randomProductView2.CnnString = "myConnectionString";
this.Controls.Add(randomProductView2);
```