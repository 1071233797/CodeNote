﻿Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' 有关程序集的常规信息通过下列属性集
' 控制。更改这些属性值可修改
' 与程序集关联的信息。

' 查看程序集属性的值

<Assembly: AssemblyTitle("HRPDA")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("china")>
<Assembly: AssemblyProduct("HRPDA")>
<Assembly: AssemblyCopyright("Copyright © china 2016")>
<Assembly: AssemblyTrademark("")>

<Assembly: CLSCompliant(True)>

<Assembly: ComVisible(False)>

'如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
<Assembly: Guid("321f423e-993b-47e5-ba32-e7cd4b27b790")>

' 程序集的版本信息由下面四个值组成:
'
'      主版本
'      次版本
'      内部版本号
'      修订号
'
' 可以指定所有这些值，也可以使用“内部版本号”和“修订号”的默认值，
' 方法是按如下所示使用“*”:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.0")>

'以下属性将取消显示 FxCop 警告“CA2232 : Microsoft.Usage : 向程序集添加 STAThreadAttribute 属性”
' 因为设备应用程序不支持 STA 线程。
<Assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")>
