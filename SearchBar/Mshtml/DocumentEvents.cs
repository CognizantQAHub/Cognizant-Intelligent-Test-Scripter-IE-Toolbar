using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;

namespace ieaulbtest
{
    [ComImport, TypeLibType((short)0x1010), InterfaceType((short)2), Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
    public interface DWebBrowserEvents2
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x66)]
        void StatusTextChange([In, MarshalAs(UnmanagedType.BStr)] string Text);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x6c)]
        void ProgressChange([In] int Progress, [In] int ProgressMax);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x69)]
        void CommandStateChange([In] int Command, [In] bool Enable);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x6a)]
        void DownloadBegin();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x68)]
        void DownloadComplete();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x71)]
        void TitleChange([In, MarshalAs(UnmanagedType.BStr)] string Text);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x70)]
        void PropertyChange([In, MarshalAs(UnmanagedType.BStr)] string szProperty);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(250)]
        void BeforeNavigate2([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In, MarshalAs(UnmanagedType.Struct)] ref object URL, [In, MarshalAs(UnmanagedType.Struct)] ref object Flags, [In, MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [In, MarshalAs(UnmanagedType.Struct)] ref object PostData, [In, MarshalAs(UnmanagedType.Struct)] ref object Headers, [In, Out] ref bool Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xfb)]
        void NewWindow2([In, Out, MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In, Out] ref bool Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xfc)]
        void NavigateComplete2([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In, MarshalAs(UnmanagedType.Struct)] ref object URL);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x103)]
        void DocumentComplete([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In, MarshalAs(UnmanagedType.Struct)] ref object URL);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xfd)]
        void OnQuit();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xfe)]
        void OnVisible([In] bool Visible);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xff)]
        void OnToolBar([In] bool ToolBar);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x100)]
        void OnMenuBar([In] bool MenuBar);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x101)]
        void OnStatusBar([In] bool StatusBar);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x102)]
        void OnFullScreen([In] bool FullScreen);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(260)]
        void OnTheaterMode([In] bool TheaterMode);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x106)]
        void WindowSetResizable([In] bool Resizable);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x108)]
        void WindowSetLeft([In] int Left);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x109)]
        void WindowSetTop([In] int Top);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x10a)]
        void WindowSetWidth([In] int Width);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x10b)]
        void WindowSetHeight([In] int Height);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x107)]
        void WindowClosing([In] bool IsChildWindow, [In, Out] ref bool Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x10c)]
        void ClientToHostWindow([In, Out] ref int CX, [In, Out] ref int CY);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x10d)]
        void SetSecureLockIcon([In] int SecureLockIcon);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(270)]
        void FileDownload([In, Out] ref bool Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x10f)]
        void NavigateError([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In, MarshalAs(UnmanagedType.Struct)] ref object URL, [In, MarshalAs(UnmanagedType.Struct)] ref object Frame, [In, MarshalAs(UnmanagedType.Struct)] ref object StatusCode, [In, Out] ref bool Cancel);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xe1)]
        void PrintTemplateInstantiation([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xe2)]
        void PrintTemplateTeardown([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0xe3)]
        void UpdatePageStatus([In, MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In, MarshalAs(UnmanagedType.Struct)] ref object nPage, [In, MarshalAs(UnmanagedType.Struct)] ref object fDone);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x110)]
        void PrivacyImpactedStateChange([In] bool bImpacted);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x111)]
        void NewWindow3([In, Out, MarshalAs(UnmanagedType.IDispatch)] ref object ppDisp, [In, Out] ref bool Cancel, [In] uint dwFlags, [In, MarshalAs(UnmanagedType.BStr)] string bstrUrlContext, [In, MarshalAs(UnmanagedType.BStr)] string bstrUrl);
    }


    [ClassInterface(ClassInterfaceType.None)]
    public sealed class DWebBrowserEvents2_Helper : DWebBrowserEvents2
    {
        #region DWebBrowserEvents2 Members

        void DWebBrowserEvents2.StatusTextChange(string Text)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.ProgressChange(int Progress, int ProgressMax)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.CommandStateChange(int Command, bool Enable)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.DownloadBegin()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.DownloadComplete()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.TitleChange(string Text)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.PropertyChange(string szProperty)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.NewWindow2(ref object ppDisp, ref bool Cancel)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.NavigateComplete2(object pDisp, ref object URL)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.DocumentComplete(object pDisp, ref object URL)
        {
            DocumentStatus ds = DocumentStatus.Instance;
            ds.DownloadComplete = true;

        }

        void DWebBrowserEvents2.OnQuit()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnVisible(bool Visible)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnToolBar(bool ToolBar)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnMenuBar(bool MenuBar)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnStatusBar(bool StatusBar)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnFullScreen(bool FullScreen)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.OnTheaterMode(bool TheaterMode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowSetResizable(bool Resizable)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowSetLeft(int Left)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowSetTop(int Top)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowSetWidth(int Width)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowSetHeight(int Height)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.WindowClosing(bool IsChildWindow, ref bool Cancel)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.ClientToHostWindow(ref int CX, ref int CY)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.SetSecureLockIcon(int SecureLockIcon)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.FileDownload(ref bool Cancel)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.NavigateError(object pDisp, ref object URL, ref object Frame, ref object StatusCode, ref bool Cancel)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.PrintTemplateInstantiation(object pDisp)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.PrintTemplateTeardown(object pDisp)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.UpdatePageStatus(object pDisp, ref object nPage, ref object fDone)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.PrivacyImpactedStateChange(bool bImpacted)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void DWebBrowserEvents2.NewWindow3(ref object ppDisp, ref bool Cancel, uint dwFlags, string bstrUrlContext, string bstrUrl)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }

}
