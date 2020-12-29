<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="20008000">
	<Property Name="CCSymbols" Type="Str"></Property>
	<Property Name="NI.LV.All.SourceOnly" Type="Bool">false</Property>
	<Property Name="NI.Project.Description" Type="Str"></Property>
	<Item Name="我的电脑" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">????/VI???</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">????/VI???</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="builds" Type="Folder" URL="../builds">
			<Property Name="NI.DISK" Type="Bool">true</Property>
		</Item>
		<Item Name="data" Type="Folder" URL="../data">
			<Property Name="NI.DISK" Type="Bool">true</Property>
		</Item>
		<Item Name="lib" Type="Folder">
			<Item Name="Beep" Type="Folder">
				<Item Name="VIs" Type="Folder"/>
				<Item Name="Beep.lvlib" Type="Library" URL="../lib/Beep/Beep.lvlib"/>
			</Item>
			<Item Name="CH375" Type="Folder">
				<Item Name="VIs" Type="Folder"/>
				<Item Name="CH375.lvlib" Type="Library" URL="../lib/CH375/CH375.lvlib"/>
				<Item Name="CH375DLL64.dll" Type="Document" URL="../lib/CH375/CH375DLL64.dll"/>
				<Item Name="USB_Control.DLL" Type="Document" URL="../lib/CH375/USB_Control.DLL"/>
			</Item>
			<Item Name="MT" Type="Folder">
				<Item Name="VIs" Type="Folder">
					<Item Name="dir.mnu" Type="Document" URL="../lib/MT/VIs/dir.mnu"/>
				</Item>
				<Item Name="dir.mnu" Type="Document" URL="../lib/MT/dir.mnu"/>
				<Item Name="MT_API.lvlib" Type="Library" URL="../lib/MT/MT_API.lvlib"/>
			</Item>
			<Item Name="SR830" Type="Folder">
				<Item Name="Private" Type="Folder"/>
				<Item Name="Public" Type="Folder">
					<Item Name="Action-Status" Type="Folder">
						<Item Name="Action-Status.mnu" Type="Document" URL="../lib/SR830/Public/Action-Status/Action-Status.mnu"/>
					</Item>
					<Item Name="Configure" Type="Folder">
						<Item Name="Low Level" Type="Folder">
							<Item Name="Configure_Low Level.mnu" Type="Document" URL="../lib/SR830/Public/Configure/Low Level/Configure_Low Level.mnu"/>
						</Item>
						<Item Name="Configure.mnu" Type="Document" URL="../lib/SR830/Public/Configure/Configure.mnu"/>
					</Item>
					<Item Name="Data" Type="Folder">
						<Item Name="Low Level" Type="Folder">
							<Item Name="Data_Low Level.mnu" Type="Document" URL="../lib/SR830/Public/Data/Low Level/Data_Low Level.mnu"/>
						</Item>
						<Item Name="Data.mnu" Type="Document" URL="../lib/SR830/Public/Data/Data.mnu"/>
					</Item>
					<Item Name="Utility" Type="Folder">
						<Item Name="Utility.mnu" Type="Document" URL="../lib/SR830/Public/Utility/Utility.mnu"/>
					</Item>
				</Item>
				<Item Name="SR830.lvlib" Type="Library" URL="../lib/SR830/SR830.lvlib"/>
			</Item>
		</Item>
		<Item Name="module" Type="Folder">
			<Item Name="CH375" Type="Folder">
				<Item Name="VIs" Type="Folder">
					<Item Name="CH375_Abs.vi" Type="VI" URL="../module/CH375/VIs/CH375_Abs.vi"/>
					<Item Name="CH375_Get.vi" Type="VI" URL="../module/CH375/VIs/CH375_Get.vi"/>
					<Item Name="CH375_Open.vi" Type="VI" URL="../module/CH375/VIs/CH375_Open.vi"/>
					<Item Name="CH375_Rel.vi" Type="VI" URL="../module/CH375/VIs/CH375_Rel.vi"/>
					<Item Name="CH375_Reset.vi" Type="VI" URL="../module/CH375/VIs/CH375_Reset.vi"/>
				</Item>
				<Item Name="CH375_Test.vi" Type="VI" URL="../module/CH375/CH375_Test.vi"/>
				<Item Name="Global_CH375.vi" Type="VI" URL="../module/CH375/Global_CH375.vi"/>
			</Item>
			<Item Name="Data" Type="Folder">
				<Item Name="Data_Close.vi" Type="VI" URL="../module/Data/Data_Close.vi"/>
				<Item Name="Data_Limit.vi" Type="VI" URL="../module/Data/Data_Limit.vi"/>
				<Item Name="Data_Open.vi" Type="VI" URL="../module/Data/Data_Open.vi"/>
				<Item Name="Data_Write.vi" Type="VI" URL="../module/Data/Data_Write.vi"/>
			</Item>
			<Item Name="MT" Type="Folder">
				<Item Name="VIs" Type="Folder">
					<Item Name="MT_Abs.vi" Type="VI" URL="../module/MT/VIs/MT_Abs.vi"/>
					<Item Name="MT_Close.vi" Type="VI" URL="../module/MT/VIs/MT_Close.vi"/>
					<Item Name="MT_Get.vi" Type="VI" URL="../module/MT/VIs/MT_Get.vi"/>
					<Item Name="MT_Open.vi" Type="VI" URL="../module/MT/VIs/MT_Open.vi"/>
					<Item Name="MT_Rel.vi" Type="VI" URL="../module/MT/VIs/MT_Rel.vi"/>
					<Item Name="MT_Tran.vi" Type="VI" URL="../module/MT/VIs/MT_Tran.vi"/>
				</Item>
				<Item Name="MT_Test.vi" Type="VI" URL="../module/MT/MT_Test.vi"/>
			</Item>
			<Item Name="Scan" Type="Folder">
				<Item Name="Scan_Percent.vi" Type="VI" URL="../module/Scan/Scan_Percent.vi"/>
				<Item Name="Scan_Time.vi" Type="VI" URL="../module/Scan/Scan_Time.vi"/>
				<Item Name="Scan_Update.vi" Type="VI" URL="../module/Scan/Scan_Update.vi"/>
			</Item>
			<Item Name="SR830" Type="Folder">
				<Item Name="VIs" Type="Folder">
					<Item Name="SR830_Close.vi" Type="VI" URL="../module/SR830/VIs/SR830_Close.vi"/>
					<Item Name="SR830_Get.vi" Type="VI" URL="../module/SR830/VIs/SR830_Get.vi"/>
					<Item Name="SR830_Open.vi" Type="VI" URL="../module/SR830/VIs/SR830_Open.vi"/>
				</Item>
				<Item Name="SR830_Test.vi" Type="VI" URL="../module/SR830/SR830_Test.vi"/>
			</Item>
		</Item>
		<Item Name="vi" Type="Folder">
			<Item Name="NJU Project.vi" Type="VI" URL="../vi/NJU Project.vi"/>
		</Item>
		<Item Name="依赖关系" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="3D Plot Datatype.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/3D Plot Datatype/3D Plot Datatype.lvclass"/>
				<Item Name="3D Plot.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/3D Plot/3D Plot.lvclass"/>
				<Item Name="3D Surface Datatype.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Surface/3D Surface Datatype/3D Surface Datatype.lvclass"/>
				<Item Name="3D Surface.lvclass" Type="LVClass" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Surface/3D Surface/3D Surface.lvclass"/>
				<Item Name="3D Surface.xctl" Type="XControl" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Surface/3D Surface XCtrl/3D Surface.xctl"/>
				<Item Name="3DMathPlot Action String.ctl" Type="VI" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/Action String/3DMathPlot Action String.ctl"/>
				<Item Name="3DMathPlot Action String.vi" Type="VI" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/Action String/3DMathPlot Action String.vi"/>
				<Item Name="3DMathPlot Ctrl Act Cluster.ctl" Type="VI" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/Action String/3DMathPlot Ctrl Act Cluster.ctl"/>
				<Item Name="3DMathPlot Ctrl Act Queue.ctl" Type="VI" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/Action String/3DMathPlot Ctrl Act Queue.ctl"/>
				<Item Name="3DMathPlot State Class.ctl" Type="VI" URL="/&lt;vilib&gt;/Math Plots/3D Math Plots/3D Plot/Action String/3DMathPlot State Class.ctl"/>
				<Item Name="8.6CompatibleGlobalVar.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/config.llb/8.6CompatibleGlobalVar.vi"/>
				<Item Name="Acquire Input Data.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/Acquire Input Data.vi"/>
				<Item Name="Application Directory.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/file.llb/Application Directory.vi"/>
				<Item Name="Beep.vi" Type="VI" URL="/&lt;vilib&gt;/Platform/system.llb/Beep.vi"/>
				<Item Name="Bit-array To Byte-array.vi" Type="VI" URL="/&lt;vilib&gt;/picture/pictutil.llb/Bit-array To Byte-array.vi"/>
				<Item Name="BuildHelpPath.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/BuildHelpPath.vi"/>
				<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
				<Item Name="Check Path.vi" Type="VI" URL="/&lt;vilib&gt;/picture/jpeg.llb/Check Path.vi"/>
				<Item Name="Check Special Tags.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Check Special Tags.vi"/>
				<Item Name="Clear Errors.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Clear Errors.vi"/>
				<Item Name="Close Input Device.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/Close Input Device.vi"/>
				<Item Name="closeJoystick.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/closeJoystick.vi"/>
				<Item Name="closeKeyboard.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/closeKeyboard.vi"/>
				<Item Name="closeMouse.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/closeMouse.vi"/>
				<Item Name="Color to RGB.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/colorconv.llb/Color to RGB.vi"/>
				<Item Name="Convert property node font to graphics font.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Convert property node font to graphics font.vi"/>
				<Item Name="Create Mask By Alpha.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Create Mask By Alpha.vi"/>
				<Item Name="Details Display Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Details Display Dialog.vi"/>
				<Item Name="DialogType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogType.ctl"/>
				<Item Name="DialogTypeEnum.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/DialogTypeEnum.ctl"/>
				<Item Name="Directory of Top Level VI.vi" Type="VI" URL="/&lt;vilib&gt;/picture/jpeg.llb/Directory of Top Level VI.vi"/>
				<Item Name="Draw Flattened Pixmap.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Draw Flattened Pixmap.vi"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Error Code Database.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Code Database.vi"/>
				<Item Name="ErrorDescriptions.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/ErrorDescriptions.vi"/>
				<Item Name="errorList.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/errorList.vi"/>
				<Item Name="ErrWarn.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/ErrWarn.ctl"/>
				<Item Name="eventvkey.ctl" Type="VI" URL="/&lt;vilib&gt;/event_ctls.llb/eventvkey.ctl"/>
				<Item Name="Find Tag.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Find Tag.vi"/>
				<Item Name="FixBadRect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/pictutil.llb/FixBadRect.vi"/>
				<Item Name="Format Message String.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Format Message String.vi"/>
				<Item Name="General Error Handler Core CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler Core CORE.vi"/>
				<Item Name="General Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/General Error Handler.vi"/>
				<Item Name="Get String Text Bounds.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Get String Text Bounds.vi"/>
				<Item Name="Get Text Rect.vi" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/Get Text Rect.vi"/>
				<Item Name="GetHelpDir.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetHelpDir.vi"/>
				<Item Name="GetRTHostConnectedProp.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/GetRTHostConnectedProp.vi"/>
				<Item Name="imagedata.ctl" Type="VI" URL="/&lt;vilib&gt;/picture/picture.llb/imagedata.ctl"/>
				<Item Name="Intialize Keyboard.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/Intialize Keyboard.vi"/>
				<Item Name="joystickAcquire.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/joystickAcquire.vi"/>
				<Item Name="keyboardAcquire.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/keyboardAcquire.vi"/>
				<Item Name="Longest Line Length in Pixels.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Longest Line Length in Pixels.vi"/>
				<Item Name="LV3DPointTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LV3DPointTypeDef.ctl"/>
				<Item Name="LVBoundsTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVBoundsTypeDef.ctl"/>
				<Item Name="LVRectTypeDef.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/miscctls.llb/LVRectTypeDef.ctl"/>
				<Item Name="mouseAcquire.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/inputDevices.llb/mouseAcquire.vi"/>
				<Item Name="NI_3D Picture Control.lvlib" Type="Library" URL="/&lt;vilib&gt;/picture/3D Picture Control/NI_3D Picture Control.lvlib"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="NI_LVConfig.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/config.llb/NI_LVConfig.lvlib"/>
				<Item Name="NI_Math Plot Private Lib.lvlib" Type="Library" URL="/&lt;vilib&gt;/Math Plots/Plot Private Lib/NI_Math Plot Private Lib.lvlib"/>
				<Item Name="NI_PackedLibraryUtility.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/LVLibp/NI_PackedLibraryUtility.lvlib"/>
				<Item Name="Not Found Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Not Found Dialog.vi"/>
				<Item Name="Read PNG File.vi" Type="VI" URL="/&lt;vilib&gt;/picture/png.llb/Read PNG File.vi"/>
				<Item Name="Search and Replace Pattern.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Search and Replace Pattern.vi"/>
				<Item Name="Set Bold Text.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set Bold Text.vi"/>
				<Item Name="Set String Value.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Set String Value.vi"/>
				<Item Name="Simple Error Handler.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Simple Error Handler.vi"/>
				<Item Name="Space Constant.vi" Type="VI" URL="/&lt;vilib&gt;/dlg_ctls.llb/Space Constant.vi"/>
				<Item Name="TagReturnType.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/TagReturnType.ctl"/>
				<Item Name="Three Button Dialog CORE.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog CORE.vi"/>
				<Item Name="Three Button Dialog.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Three Button Dialog.vi"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="Version To Dotted String.vi" Type="VI" URL="/&lt;vilib&gt;/_xctls/Version To Dotted String.vi"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
				<Item Name="XControlSupport.lvlib" Type="Library" URL="/&lt;vilib&gt;/_xctls/XControlSupport.lvlib"/>
			</Item>
			<Item Name="lvinput.dll" Type="Document" URL="/&lt;resource&gt;/lvinput.dll"/>
			<Item Name="MT_API_64.dll" Type="Document" URL="../lib/MT/MT_API_64.dll"/>
		</Item>
		<Item Name="程序生成规范" Type="Build">
			<Item Name="NJU_Project" Type="EXE">
				<Property Name="App_INI_aliasGUID" Type="Str">{CCA2ECEA-9B60-4F51-B126-DE116CBF6AF1}</Property>
				<Property Name="App_INI_GUID" Type="Str">{F02F68FC-1F38-41BA-ABF0-B8E0354BAEF1}</Property>
				<Property Name="App_serverConfig.httpPort" Type="Int">8002</Property>
				<Property Name="App_serverType" Type="Int">1</Property>
				<Property Name="Bld_autoIncrement" Type="Bool">true</Property>
				<Property Name="Bld_buildCacheID" Type="Str">{042DEE31-4802-476E-A554-1F75A6AB039B}</Property>
				<Property Name="Bld_buildSpecDescription" Type="Str">NJU_Project</Property>
				<Property Name="Bld_buildSpecName" Type="Str">NJU_Project</Property>
				<Property Name="Bld_defaultLanguage" Type="Str">ChineseS</Property>
				<Property Name="Bld_excludeInlineSubVIs" Type="Bool">true</Property>
				<Property Name="Bld_excludeLibraryItems" Type="Bool">true</Property>
				<Property Name="Bld_excludePolymorphicVIs" Type="Bool">true</Property>
				<Property Name="Bld_localDestDir" Type="Path">../builds</Property>
				<Property Name="Bld_localDestDirType" Type="Str">relativeToProject</Property>
				<Property Name="Bld_modifyLibraryFile" Type="Bool">true</Property>
				<Property Name="Bld_previewCacheID" Type="Str">{A4768303-AD54-43D7-BA31-E36639FA1990}</Property>
				<Property Name="Bld_version.build" Type="Int">53</Property>
				<Property Name="Bld_version.major" Type="Int">2</Property>
				<Property Name="Destination[0].destName" Type="Str">NJU_Project.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/NJU_Project.exe</Property>
				<Property Name="Destination[0].path.type" Type="Str">relativeToProject</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">????</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/data</Property>
				<Property Name="Destination[1].path.type" Type="Str">relativeToProject</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_iconItemID" Type="Ref">/我的电脑/data/NJU.ico</Property>
				<Property Name="Source[0].itemID" Type="Str">{EE9B25D6-FF46-4DC8-A90C-E445152B4244}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/我的电脑/vi/NJU Project.vi</Property>
				<Property Name="Source[1].properties[0].type" Type="Str">Show toolbar</Property>
				<Property Name="Source[1].properties[0].value" Type="Bool">false</Property>
				<Property Name="Source[1].properties[1].type" Type="Str">Show Abort button</Property>
				<Property Name="Source[1].properties[1].value" Type="Bool">false</Property>
				<Property Name="Source[1].propertiesCount" Type="Int">2</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="Source[2].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[2].itemID" Type="Ref">/我的电脑/data/NJU.ico</Property>
				<Property Name="Source[3].Container.applyInclusion" Type="Bool">true</Property>
				<Property Name="Source[3].Container.depDestIndex" Type="Int">0</Property>
				<Property Name="Source[3].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[3].itemID" Type="Ref">/我的电脑/data</Property>
				<Property Name="Source[3].sourceInclusion" Type="Str">Include</Property>
				<Property Name="Source[3].type" Type="Str">Container</Property>
				<Property Name="SourceCount" Type="Int">4</Property>
				<Property Name="TgtF_companyName" Type="Str">ZZU &amp; NJU</Property>
				<Property Name="TgtF_fileDescription" Type="Str">NJU_Project</Property>
				<Property Name="TgtF_internalName" Type="Str">NJU_Project</Property>
				<Property Name="TgtF_legalCopyright" Type="Str">zzudongxiang@163.com Copy Right 2020 </Property>
				<Property Name="TgtF_productName" Type="Str">NJU_Project</Property>
				<Property Name="TgtF_targetfileGUID" Type="Str">{A87E2FB1-ADA1-44DB-9F25-B3BA628FBC65}</Property>
				<Property Name="TgtF_targetfileName" Type="Str">NJU_Project.exe</Property>
				<Property Name="TgtF_versionIndependent" Type="Bool">true</Property>
			</Item>
		</Item>
	</Item>
</Project>
