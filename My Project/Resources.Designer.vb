﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("nkc_test.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {
        '''     &quot;_id&quot;: &quot;_design/counters&quot;,
        '''     &quot;language&quot;: &quot;javascript&quot;,
        '''     &quot;updates&quot;: {
        '''      &quot;counters&quot;: &quot;function (doc, req){if (!doc.count) doc.count = 0;doc.count++;return [doc, toJSON(doc.count)];}&quot;
        '''      }
        '''}.
        '''</summary>
        Friend ReadOnly Property counter() As String
            Get
                Return ResourceManager.GetString("counter", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {
        '''     &quot;_id&quot;: &quot;_design/thread&quot;,
        '''     &quot;language&quot;: &quot;javascript&quot;,
        '''     &quot;views&quot;: {
        '''     &quot;thread&quot;: {
        '''     &quot;map&quot;: &quot;function(doc) { emit([doc.tid,doc.toc], doc);}&quot;
        '''      }
        '''   }
        '''}.
        '''</summary>
        Friend ReadOnly Property thread() As String
            Get
                Return ResourceManager.GetString("thread", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
