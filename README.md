# C-Sharp-Calculator
A Simple Calculator Develop with C#, Visual Studio

### 處理路徑錯誤問題
今天在學校把程式寫完之後，可能是不小心哪裡設定錯誤，造成程式碼資料夾路徑跑掉，經過測試後發現是以下這個檔案裡面的內容意外被更動到

請注意程式碼路徑是否有異常的地方，以下程式碼已經正常了

WindowsFormsApp1.csproj

檢查程式碼路徑
```
.
.
.
省略
.
.
.
<ItemGroup>
    <Compile Include="Form1.cs">                         //注意
      <SubType>Form</SubType>                            //注意
    </Compile>                                           //注意
    <Compile Include="Form1.Designer.cs">                //注意
      <DependentUpon>Form1.cs</DependentUpon>            //注意
    </Compile>                                           //注意
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
.
.
.
省略
.
.
.
```
