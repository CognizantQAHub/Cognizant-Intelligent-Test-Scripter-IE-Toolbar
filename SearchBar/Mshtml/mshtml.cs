using System;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace mshtml
{

    [Guid("3050F55F-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [CoClass(typeof(HTMLDocumentClass))]
    public interface HTMLDocument : DispHTMLDocument
    {
    }


    [Guid("25336920-03F9-11CF-8FD0-00AA00686F13")]
    [ComImport]
    [TypeLibType((short)2)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces("HTMLDocumentEvents, HTMLDocumentEvents2, HTMLDocumentEvents3")]
    public class HTMLDocumentClass  //: DispHTMLDocument  //IHTMLDocument2, IHTMLDocument3, IHTMLDocument4, IHTMLDocument5, IHTMLDocument6, IHTMLDOMNode, IHTMLDOMNode2, IDocumentSelector, IHTMLDOMConstructor, DispHTMLDocument, HTMLDocument, , , HTMLDocumentEvents_EventHTMLDocumentEvents2_EventHTMLDocumentEvents3_Event
    {
    }

    [Guid("3050F55F-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4112)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface DispHTMLDocument
    {
        [DispId(1054)]
        void write([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] object[] psarray);

        [DispId(1055)]
        void writeln([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] object[] psarray);

        [DispId(1056)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object open([MarshalAs(UnmanagedType.BStr)] string url, object name, object features, object replace);

        [DispId(1057)]
        void close();

        [DispId(1058)]
        void clear();

        [DispId(1059)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandSupported([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1060)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandEnabled([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1061)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandState([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1062)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandIndeterm([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1063)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string queryCommandText([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1064)]
        object queryCommandValue([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1065)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommand([MarshalAs(UnmanagedType.BStr)] string cmdID, [MarshalAs(UnmanagedType.VariantBool)] bool showUI, object value);

        [DispId(1066)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommandShowHelp([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1067)]
        IHTMLElement createElement([MarshalAs(UnmanagedType.BStr)] string eTag);

        [DispId(1068)]
        IHTMLElement elementFromPoint(int x, int y);

        [DispId(1070)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        [DispId(1071)]
        IHTMLStyleSheet createStyleSheet([MarshalAs(UnmanagedType.BStr)] string bstrHref, int lIndex);

        [DispId(1072)]
        void releaseCapture();

        [DispId(1073)]
        void recalc([MarshalAs(UnmanagedType.VariantBool)] bool fForce);

        [DispId(1074)]
        IHTMLDOMNode createTextNode([MarshalAs(UnmanagedType.BStr)] string text);

        [DispId(-2147417605)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool attachEvent([MarshalAs(UnmanagedType.BStr)] 
        string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(-2147417604)]
        void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(1076)]
        IHTMLDocument2 createDocumentFragment();

        [DispId(1086)]
        IHTMLElementCollection getElementsByName([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(1088)]
        IHTMLElement getElementById([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(1087)]
        IHTMLElementCollection getElementsByTagName([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(1089)]
        void focus();

        [DispId(1090)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasFocus();

        [DispId(1092)]
        IHTMLDocument2 createDocumentFromUrl([MarshalAs(UnmanagedType.BStr)] string bstrUrl, [MarshalAs(UnmanagedType.BStr)] string bstrOptions);

        [DispId(1094)]
        IHTMLEventObj CreateEventObject([In] ref object pvarEventObject);

        [DispId(1095)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool FireEvent([MarshalAs(UnmanagedType.BStr)] string bstrEventName, [In] ref object pvarEventObject);

        [DispId(1096)]
        IHTMLRenderStyle createRenderStyle([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(1100)]
        IHTMLDOMAttribute createAttribute([MarshalAs(UnmanagedType.BStr)] string bstrattrName);

        [DispId(1101)]
        IHTMLDOMNode createComment([MarshalAs(UnmanagedType.BStr)] string bstrdata);

        [DispId(1107)]
        IHTMLElement2 ie8_getElementById([MarshalAs(UnmanagedType.BStr)] string bstrId);

        [DispId(1109)]
        void updateSettings();

        [DispId(-2147417064)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasChildNodes();

        [DispId(-2147417061)]
        IHTMLDOMNode insertBefore(IHTMLDOMNode newChild, object refChild);

        [DispId(-2147417060)]
        IHTMLDOMNode removeChild(IHTMLDOMNode oldChild);

        [DispId(-2147417059)]
        IHTMLDOMNode replaceChild(IHTMLDOMNode newChild, IHTMLDOMNode oldChild);

        [DispId(-2147417051)]
        IHTMLDOMNode cloneNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417046)]
        IHTMLDOMNode removeNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417044)]
        IHTMLDOMNode swapNode(IHTMLDOMNode otherNode);

        [DispId(-2147417045)]
        IHTMLDOMNode replaceNode(IHTMLDOMNode replacement);

        [DispId(-2147417039)]
        IHTMLDOMNode appendChild(IHTMLDOMNode newChild);

        [DispId(1105)]
        IHTMLElement querySelector([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(1106)]
        IHTMLDOMChildrenCollection querySelectorAll([MarshalAs(UnmanagedType.BStr)] string v);

        IHTMLElement activeElement
        {
            [DispId(1005)]
            get;
        }

        object alinkColor
        {
            [DispId(1022)]
            get;
            [DispId(1022)]
            set;
        }

        IHTMLElementCollection all
        {
            [DispId(1003)]
            get;
        }

        IHTMLElementCollection anchors
        {
            [DispId(1007)]
            get;
        }

        IHTMLElementCollection applets
        {
            [DispId(1008)]
            get;
        }

        object attributes
        {
            [DispId(-2147417062)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string baseUrl
        {
            [DispId(1080)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1080)]
            set;
        }

        object bgColor
        {
            [DispId(-501)]
            get;
            [DispId(-501)]
            set;
        }

        IHTMLElement body
        {
            [DispId(1004)]
            get;
        }

        string charset
        {
            [DispId(1032)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1032)]
            set;
        }

        object childNodes
        {
            [DispId(-2147417063)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLDocumentCompatibleInfoCollection compatible
        {
            [DispId(1103)]
            get;
        }

        string compatMode
        {
            [DispId(1102)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object constructor
        {
            [DispId(-2147417603)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string cookie
        {
            [DispId(1030)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1030)]
            set;
        }

        string defaultCharset
        {
            [DispId(1033)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1033)]
            set;
        }

        string designMode
        {
            [DispId(1014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1014)]
            set;
        }

        string dir
        {
            [DispId(-2147412995)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412995)]
            set;
        }

        IHTMLDOMNode doctype
        {
            [DispId(1098)]
            get;
        }

        IHTMLElement documentElement
        {
            [DispId(1075)]
            get;
        }

        object documentMode
        {
            [DispId(1104)]
            get;
        }

        string domain
        {
            [DispId(1029)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1029)]
            set;
        }

        IHTMLElementCollection embeds
        {
            [DispId(1015)]
            get;
        }

        bool enableDownload
        {
            [DispId(1079)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1079)]
            set;
        }

        bool expando
        {
            [DispId(1031)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1031)]
            set;
        }

        object fgColor
        {
            [DispId(-2147413110)]
            get;
            [DispId(-2147413110)]
            set;
        }

        string fileCreatedDate
        {
            [DispId(1043)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileModifiedDate
        {
            [DispId(1044)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileSize
        {
            [DispId(1042)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileUpdatedDate
        {
            [DispId(1045)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLDOMNode firstChild
        {
            [DispId(-2147417036)]
            get;
        }

        IHTMLElementCollection forms
        {
            [DispId(1010)]
            get;
        }

        IHTMLFramesCollection2 frames
        {
            [DispId(1019)]
            get;
        }

        IHTMLElementCollection images
        {
            [DispId(1011)]
            get;
        }

        IHTMLDOMImplementation implementation
        {
            [DispId(1099)]
            get;
        }

        bool inheritStyleSheets
        {
            [DispId(1082)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1082)]
            set;
        }

        IHTMLDOMNode lastChild
        {
            [DispId(-2147417035)]
            get;
        }

        string lastModified
        {
            [DispId(1028)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object linkColor
        {
            [DispId(1024)]
            get;
            [DispId(1024)]
            set;
        }

        IHTMLElementCollection links
        {
            [DispId(1009)]
            get;
        }

        IHTMLLocation location
        {
            [DispId(1026)]
            get;
        }

        string media
        {
            [DispId(1093)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1093)]
            set;
        }

        string mimeType
        {
            [DispId(1041)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string nameProp
        {
            [DispId(1048)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object namespaces
        {
            [DispId(1091)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLDOMNode nextSibling
        {
            [DispId(-2147417033)]
            get;
        }

        string nodeName
        {
            [DispId(-2147417038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int nodeType
        {
            [DispId(-2147417066)]
            get;
        }

        object nodeValue
        {
            [DispId(-2147417037)]
            get;
            [DispId(-2147417037)]
            set;
        }

        object onactivate
        {
            [DispId(-2147412025)]
            get;
            [DispId(-2147412025)]
            set;
        }

        object onafterupdate
        {
            [DispId(-2147412090)]
            get;
            [DispId(-2147412090)]
            set;
        }

        object onbeforeactivate
        {
            [DispId(-2147412022)]
            get;
            [DispId(-2147412022)]
            set;
        }

        object onbeforedeactivate
        {
            [DispId(-2147412035)]
            get;
            [DispId(-2147412035)]
            set;
        }

        object onbeforeeditfocus
        {
            [DispId(-2147412043)]
            get;
            [DispId(-2147412043)]
            set;
        }

        object onbeforeupdate
        {
            [DispId(-2147412091)]
            get;
            [DispId(-2147412091)]
            set;
        }

        object oncellchange
        {
            [DispId(-2147412048)]
            get;
            [DispId(-2147412048)]
            set;
        }

        object onclick
        {
            [DispId(-2147412104)]
            get;
            [DispId(-2147412104)]
            set;
        }

        object oncontextmenu
        {
            [DispId(-2147412047)]
            get;
            [DispId(-2147412047)]
            set;
        }

        object oncontrolselect
        {
            [DispId(-2147412033)]
            get;
            [DispId(-2147412033)]
            set;
        }

        object ondataavailable
        {
            [DispId(-2147412071)]
            get;
            [DispId(-2147412071)]
            set;
        }

        object ondatasetchanged
        {
            [DispId(-2147412072)]
            get;
            [DispId(-2147412072)]
            set;
        }

        object ondatasetcomplete
        {
            [DispId(-2147412070)]
            get;
            [DispId(-2147412070)]
            set;
        }

        object ondblclick
        {
            [DispId(-2147412103)]
            get;
            [DispId(-2147412103)]
            set;
        }

        object ondeactivate
        {
            [DispId(-2147412024)]
            get;
            [DispId(-2147412024)]
            set;
        }

        object ondragstart
        {
            [DispId(-2147412077)]
            get;
            [DispId(-2147412077)]
            set;
        }

        object onerrorupdate
        {
            [DispId(-2147412074)]
            get;
            [DispId(-2147412074)]
            set;
        }

        object onfocusin
        {
            [DispId(-2147412021)]
            get;
            [DispId(-2147412021)]
            set;
        }

        object onfocusout
        {
            [DispId(-2147412020)]
            get;
            [DispId(-2147412020)]
            set;
        }

        object onhelp
        {
            [DispId(-2147412099)]
            get;
            [DispId(-2147412099)]
            set;
        }

        object onkeydown
        {
            [DispId(-2147412107)]
            get;
            [DispId(-2147412107)]
            set;
        }

        object onkeypress
        {
            [DispId(-2147412105)]
            get;
            [DispId(-2147412105)]
            set;
        }

        object onkeyup
        {
            [DispId(-2147412106)]
            get;
            [DispId(-2147412106)]
            set;
        }

        object onmousedown
        {
            [DispId(-2147412110)]
            get;
            [DispId(-2147412110)]
            set;
        }

        object onmousemove
        {
            [DispId(-2147412108)]
            get;
            [DispId(-2147412108)]
            set;
        }

        object onmouseout
        {
            [DispId(-2147412111)]
            get;
            [DispId(-2147412111)]
            set;
        }

        object onmouseover
        {
            [DispId(-2147412112)]
            get;
            [DispId(-2147412112)]
            set;
        }

        object onmouseup
        {
            [DispId(-2147412109)]
            get;
            [DispId(-2147412109)]
            set;
        }

        object onmousewheel
        {
            [DispId(-2147412036)]
            get;
            [DispId(-2147412036)]
            set;
        }

        object onpropertychange
        {
            [DispId(-2147412065)]
            get;
            [DispId(-2147412065)]
            set;
        }

        object onreadystatechange
        {
            [DispId(-2147412087)]
            get;
            [DispId(-2147412087)]
            set;
        }

        object onrowenter
        {
            [DispId(-2147412093)]
            get;
            [DispId(-2147412093)]
            set;
        }

        object onrowexit
        {
            [DispId(-2147412094)]
            get;
            [DispId(-2147412094)]
            set;
        }

        object onrowsdelete
        {
            [DispId(-2147412050)]
            get;
            [DispId(-2147412050)]
            set;
        }

        object onrowsinserted
        {
            [DispId(-2147412049)]
            get;
            [DispId(-2147412049)]
            set;
        }

        object onselectionchange
        {
            [DispId(-2147412032)]
            get;
            [DispId(-2147412032)]
            set;
        }

        object onselectstart
        {
            [DispId(-2147412075)]
            get;
            [DispId(-2147412075)]
            set;
        }

        object onstop
        {
            [DispId(-2147412044)]
            get;
            [DispId(-2147412044)]
            set;
        }

        object onstorage
        {
            [DispId(-2147412012)]
            get;
            [DispId(-2147412012)]
            set;
        }

        object onstoragecommit
        {
            [DispId(-2147412011)]
            get;
            [DispId(-2147412011)]
            set;
        }

        object ownerDocument
        {
            [DispId(-2147416999)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLDocument2 parentDocument
        {
            [DispId(1078)]
            get;
        }

        IHTMLDOMNode parentNode
        {
            [DispId(-2147417065)]
            get;
        }

        IHTMLWindow2 parentWindow
        {
            [DispId(1034)]
            get;
        }

        IHTMLElementCollection plugins
        {
            [DispId(1021)]
            get;
        }

        IHTMLDOMNode previousSibling
        {
            [DispId(-2147417034)]
            get;
        }

        string protocol
        {
            [DispId(1047)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string readyState
        {
            [DispId(1018)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string referrer
        {
            [DispId(1027)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object Script
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLElementCollection scripts
        {
            [DispId(1013)]
            get;
        }

        string security
        {
            [DispId(1046)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLSelectionObject selection
        {
            [DispId(1017)]
            get;
        }

        IHTMLStyleSheetsCollection styleSheets
        {
            [DispId(1069)]
            get;
        }

        string title
        {
            [DispId(1012)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1012)]
            set;
        }

        string uniqueID
        {
            [DispId(1077)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string url
        {
            [DispId(1025)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1025)]
            set;
        }

        string URLUnencoded
        {
            [DispId(1097)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object vlinkColor
        {
            [DispId(1023)]
            get;
            [DispId(1023)]
            set;
        }
    }

    [Guid("3050F5DA-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDOMNode
    {
        [DispId(-2147417064)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasChildNodes();

        [DispId(-2147417061)]
        IHTMLDOMNode insertBefore(IHTMLDOMNode newChild, object refChild);

        [DispId(-2147417060)]
        IHTMLDOMNode removeChild(IHTMLDOMNode oldChild);

        [DispId(-2147417059)]
        IHTMLDOMNode replaceChild(IHTMLDOMNode newChild, IHTMLDOMNode oldChild);

        [DispId(-2147417051)]
        IHTMLDOMNode cloneNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417046)]
        IHTMLDOMNode removeNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417044)]
        IHTMLDOMNode swapNode(IHTMLDOMNode otherNode);

        [DispId(-2147417045)]
        IHTMLDOMNode replaceNode(IHTMLDOMNode replacement);

        [DispId(-2147417039)]
        IHTMLDOMNode appendChild(IHTMLDOMNode newChild);

        object attributes
        {
            [DispId(-2147417062)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        object childNodes
        {
            [DispId(-2147417063)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLDOMNode firstChild
        {
            [DispId(-2147417036)]
            get;
        }

        IHTMLDOMNode lastChild
        {
            [DispId(-2147417035)]
            get;
        }

        IHTMLDOMNode nextSibling
        {
            [DispId(-2147417033)]
            get;
        }

        string nodeName
        {
            [DispId(-2147417038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int nodeType
        {
            [DispId(-2147417066)]
            get;
        }

        object nodeValue
        {
            [DispId(-2147417037)]
            get;
            [DispId(-2147417037)]
            set;
        }

        IHTMLDOMNode parentNode
        {
            [DispId(-2147417065)]
            get;
        }

        IHTMLDOMNode previousSibling
        {
            [DispId(-2147417034)]
            get;
        }
    }


    [Guid("3050F1FF-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLElement
    {
        [DispId(-2147417611)]
        void setAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, object AttributeValue, int lFlags);

        [DispId(-2147417610)]
        object getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417609)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417093)]
        void scrollIntoView(object varargStart);

        [DispId(-2147417092)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool contains(IHTMLElement pChild);

        [DispId(-2147417082)]
        void insertAdjacentHTML([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string html);

        [DispId(-2147417081)]
        void insertAdjacentText([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string text);

        [DispId(-2147417079)]
        void click();

        [DispId(-2147417076)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        object all
        {
            [DispId(-2147417074)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

    }


    [Guid("3050F2E3-98B5-11CF-BB82-00AA00BDCE0B")]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLStyleSheet
    {
        [DispId(1009)]
        int addImport([MarshalAs(UnmanagedType.BStr)] string bstrUrl, int lIndex);

        [DispId(1010)]
        int addRule([MarshalAs(UnmanagedType.BStr)] string bstrSelector, [MarshalAs(UnmanagedType.BStr)] string bstrStyle, int lIndex);

        [DispId(1011)]
        void removeImport(int lIndex);

        [DispId(1012)]
        void removeRule(int lIndex);

        string cssText
        {
            [DispId(1014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1014)]
            set;
        }

        bool disabled
        {
            [DispId(-2147418036)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147418036)]
            set;
        }

        string href
        {
            [DispId(1006)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1006)]
            set;
        }

        string id
        {
            [DispId(1008)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLStyleSheetsCollection imports
        {
            [DispId(1005)]
            get;
        }

        string media
        {
            [DispId(1013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1013)]
            set;
        }

        IHTMLElement owningElement
        {
            [DispId(1003)]
            get;
        }

        IHTMLStyleSheet parentStyleSheet
        {
            [DispId(1002)]
            get;
        }

        bool readOnly
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        IHTMLStyleSheetRulesCollection rules
        {
            [DispId(1015)]
            get;
        }

        string title
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1001)]
            set;
        }

        string type
        {
            [DispId(1007)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }
    }


    [Guid("3050F2E5-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLStyleSheetRulesCollection
    {
        [DispId(0)]
        IHTMLStyleSheetRule item(int index);

        int length
        {
            [DispId(1001)]
            get;
        }
    }

    [Guid("3050F3CF-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLRuleStyle
    {
        [DispId(-2147417611)]
        void setAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, object AttributeValue, int lFlags);

        [DispId(-2147417610)]
        object getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417609)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        string background
        {
            [DispId(-2147413080)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413080)]
            set;
        }

        string backgroundAttachment
        {
            [DispId(-2147413067)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413067)]
            set;
        }

        object backgroundColor
        {
            [DispId(-501)]
            get;
            [DispId(-501)]
            set;
        }

        string backgroundImage
        {
            [DispId(-2147413111)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413111)]
            set;
        }

        string backgroundPosition
        {
            [DispId(-2147413066)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413066)]
            set;
        }

        object backgroundPositionX
        {
            [DispId(-2147413079)]
            get;
            [DispId(-2147413079)]
            set;
        }

        object backgroundPositionY
        {
            [DispId(-2147413078)]
            get;
            [DispId(-2147413078)]
            set;
        }

        string backgroundRepeat
        {
            [DispId(-2147413068)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413068)]
            set;
        }

        string border
        {
            [DispId(-2147413063)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413063)]
            set;
        }

        string borderBottom
        {
            [DispId(-2147413060)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413060)]
            set;
        }

        object borderBottomColor
        {
            [DispId(-2147413055)]
            get;
            [DispId(-2147413055)]
            set;
        }

        string borderBottomStyle
        {
            [DispId(-2147413045)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413045)]
            set;
        }

        object borderBottomWidth
        {
            [DispId(-2147413050)]
            get;
            [DispId(-2147413050)]
            set;
        }

        string borderColor
        {
            [DispId(-2147413058)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413058)]
            set;
        }

        string borderLeft
        {
            [DispId(-2147413059)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413059)]
            set;
        }

        object borderLeftColor
        {
            [DispId(-2147413054)]
            get;
            [DispId(-2147413054)]
            set;
        }

        string borderLeftStyle
        {
            [DispId(-2147413044)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413044)]
            set;
        }

        object borderLeftWidth
        {
            [DispId(-2147413049)]
            get;
            [DispId(-2147413049)]
            set;
        }

        string borderRight
        {
            [DispId(-2147413061)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413061)]
            set;
        }

        object borderRightColor
        {
            [DispId(-2147413056)]
            get;
            [DispId(-2147413056)]
            set;
        }

        string borderRightStyle
        {
            [DispId(-2147413046)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413046)]
            set;
        }

        object borderRightWidth
        {
            [DispId(-2147413051)]
            get;
            [DispId(-2147413051)]
            set;
        }

        string borderStyle
        {
            [DispId(-2147413048)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413048)]
            set;
        }

        string borderTop
        {
            [DispId(-2147413062)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413062)]
            set;
        }

        object borderTopColor
        {
            [DispId(-2147413057)]
            get;
            [DispId(-2147413057)]
            set;
        }

        string borderTopStyle
        {
            [DispId(-2147413047)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413047)]
            set;
        }

        object borderTopWidth
        {
            [DispId(-2147413052)]
            get;
            [DispId(-2147413052)]
            set;
        }

        string borderWidth
        {
            [DispId(-2147413053)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413053)]
            set;
        }

        string clear
        {
            [DispId(-2147413096)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413096)]
            set;
        }

        string clip
        {
            [DispId(-2147413020)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413020)]
            set;
        }

        object color
        {
            [DispId(-2147413110)]
            get;
            [DispId(-2147413110)]
            set;
        }

        string cssText
        {
            [DispId(-2147413013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413013)]
            set;
        }

        string cursor
        {
            [DispId(-2147413010)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413010)]
            set;
        }

        string display
        {
            [DispId(-2147413041)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413041)]
            set;
        }

        string filter
        {
            [DispId(-2147413030)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413030)]
            set;
        }

        string font
        {
            [DispId(-2147413071)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413071)]
            set;
        }

        string fontFamily
        {
            [DispId(-2147413094)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413094)]
            set;
        }

        object fontSize
        {
            [DispId(-2147413093)]
            get;
            [DispId(-2147413093)]
            set;
        }

        string fontStyle
        {
            [DispId(-2147413088)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413088)]
            set;
        }

        string fontVariant
        {
            [DispId(-2147413087)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413087)]
            set;
        }

        string fontWeight
        {
            [DispId(-2147413085)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413085)]
            set;
        }

        object height
        {
            [DispId(-2147418106)]
            get;
            [DispId(-2147418106)]
            set;
        }

        object left
        {
            [DispId(-2147418109)]
            get;
            [DispId(-2147418109)]
            set;
        }

        object letterSpacing
        {
            [DispId(-2147413104)]
            get;
            [DispId(-2147413104)]
            set;
        }

        object lineHeight
        {
            [DispId(-2147413106)]
            get;
            [DispId(-2147413106)]
            set;
        }

        string listStyle
        {
            [DispId(-2147413037)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413037)]
            set;
        }

        string listStyleImage
        {
            [DispId(-2147413038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413038)]
            set;
        }

        string listStylePosition
        {
            [DispId(-2147413039)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413039)]
            set;
        }

        string listStyleType
        {
            [DispId(-2147413040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413040)]
            set;
        }

        string margin
        {
            [DispId(-2147413076)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413076)]
            set;
        }

        object marginBottom
        {
            [DispId(-2147413073)]
            get;
            [DispId(-2147413073)]
            set;
        }

        object marginLeft
        {
            [DispId(-2147413072)]
            get;
            [DispId(-2147413072)]
            set;
        }

        object marginRight
        {
            [DispId(-2147413074)]
            get;
            [DispId(-2147413074)]
            set;
        }

        object marginTop
        {
            [DispId(-2147413075)]
            get;
            [DispId(-2147413075)]
            set;
        }

        string overflow
        {
            [DispId(-2147413102)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413102)]
            set;
        }

        string padding
        {
            [DispId(-2147413101)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413101)]
            set;
        }

        object paddingBottom
        {
            [DispId(-2147413098)]
            get;
            [DispId(-2147413098)]
            set;
        }

        object paddingLeft
        {
            [DispId(-2147413097)]
            get;
            [DispId(-2147413097)]
            set;
        }

        object paddingRight
        {
            [DispId(-2147413099)]
            get;
            [DispId(-2147413099)]
            set;
        }

        object paddingTop
        {
            [DispId(-2147413100)]
            get;
            [DispId(-2147413100)]
            set;
        }

        string pageBreakAfter
        {
            [DispId(-2147413034)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413034)]
            set;
        }

        string pageBreakBefore
        {
            [DispId(-2147413035)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413035)]
            set;
        }

        string position
        {
            [DispId(-2147413022)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string styleFloat
        {
            [DispId(-2147413042)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413042)]
            set;
        }

        string textAlign
        {
            [DispId(-2147418040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418040)]
            set;
        }

        string textDecoration
        {
            [DispId(-2147413077)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413077)]
            set;
        }

        bool textDecorationBlink
        {
            [DispId(-2147413090)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413090)]
            set;
        }

        bool textDecorationLineThrough
        {
            [DispId(-2147413092)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413092)]
            set;
        }

        bool textDecorationNone
        {
            [DispId(-2147413089)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413089)]
            set;
        }

        bool textDecorationOverline
        {
            [DispId(-2147413043)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413043)]
            set;
        }

        bool textDecorationUnderline
        {
            [DispId(-2147413091)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413091)]
            set;
        }

        object textIndent
        {
            [DispId(-2147413105)]
            get;
            [DispId(-2147413105)]
            set;
        }

        string textTransform
        {
            [DispId(-2147413108)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413108)]
            set;
        }

        object top
        {
            [DispId(-2147418108)]
            get;
            [DispId(-2147418108)]
            set;
        }

        object verticalAlign
        {
            [DispId(-2147413064)]
            get;
            [DispId(-2147413064)]
            set;
        }

        string visibility
        {
            [DispId(-2147413032)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413032)]
            set;
        }

        string whiteSpace
        {
            [DispId(-2147413036)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413036)]
            set;
        }

        object width
        {
            [DispId(-2147418107)]
            get;
            [DispId(-2147418107)]
            set;
        }

        object wordSpacing
        {
            [DispId(-2147413065)]
            get;
            [DispId(-2147413065)]
            set;
        }

        object zIndex
        {
            [DispId(-2147413021)]
            get;
            [DispId(-2147413021)]
            set;
        }
    }

    [Guid("3050F357-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLStyleSheetRule
    {
        bool readOnly
        {
            [DispId(1002)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        string selectorText
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1001)]
            set;
        }

        IHTMLRuleStyle style
        {
            [DispId(-2147418038)]
            get;
        }
    }


    [Guid("3050F37E-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLStyleSheetsCollection : System.Collections.IEnumerable
    {
        [DispId(0)]
        object item([In] ref object pvarIndex);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        int length
        {
            [DispId(1001)]
            get;
        }
    }


    [Guid("3050F25A-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLSelectionObject
    {
        [DispId(1001)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object createRange();

        [DispId(1002)]
        void empty();

        [DispId(1003)]
        void clear();

        string type
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }
    }


    [Guid("3050F21F-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLElementCollection : System.Collections.IEnumerable
    {
        [DispId(1501)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        [DispId(0)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object item(object name, object index);

        [DispId(1502)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object tags(object tagName);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        int length
        {
            [DispId(1500)]
            get;
            [DispId(1500)]
            set;
        }
    }


    [Guid("332C4427-26CB-11D0-B483-00C04FD90119")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLWindow2
    {
        [DispId(0)]
        object item([In] ref object pvarIndex);

        [DispId(1172)]
        int setTimeout([MarshalAs(UnmanagedType.BStr)] string expression, int msec, [In] ref object language);

        [DispId(1104)]
        void clearTimeout(int timerID);

        [DispId(1105)]
        void alert([MarshalAs(UnmanagedType.BStr)] string message);

        [DispId(1110)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool confirm([MarshalAs(UnmanagedType.BStr)] string message);

        [DispId(1111)]
        object prompt([MarshalAs(UnmanagedType.BStr)] string message, [MarshalAs(UnmanagedType.BStr)] string defstr);

        [DispId(3)]
        void close();

        [DispId(13)]
        IHTMLWindow2 open([MarshalAs(UnmanagedType.BStr)] string url, [MarshalAs(UnmanagedType.BStr)] string name, [MarshalAs(UnmanagedType.BStr)] string features, [MarshalAs(UnmanagedType.VariantBool)] bool replace);

        [DispId(25)]
        void navigate([MarshalAs(UnmanagedType.BStr)] string url);

        [DispId(1154)]
        object showModalDialog([MarshalAs(UnmanagedType.BStr)] string dialog, [In] ref object varArgIn, [In] ref object varOptions);

        [DispId(1155)]
        void showHelp([MarshalAs(UnmanagedType.BStr)] string helpURL, object helpArg, [MarshalAs(UnmanagedType.BStr)] string features);

        [DispId(1158)]
        void focus();

        [DispId(1159)]
        void blur();

        [DispId(1160)]
        void scroll(int x, int y);

        [DispId(1173)]
        int setInterval([MarshalAs(UnmanagedType.BStr)] string expression, int msec, [In] ref object language);

        [DispId(1163)]
        void clearInterval(int timerID);

        [DispId(1165)]
        object execScript([MarshalAs(UnmanagedType.BStr)] string code, [MarshalAs(UnmanagedType.BStr)] string language);

        [DispId(1166)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        [DispId(1167)]
        void scrollBy(int x, int y);

        [DispId(1168)]
        void scrollTo(int x, int y);

        [DispId(6)]
        void moveTo(int x, int y);

        [DispId(7)]
        void moveBy(int x, int y);

        [DispId(9)]
        void resizeTo(int x, int y);

        [DispId(8)]
        void resizeBy(int x, int y);

        object _newEnum
        {
            [DispId(1153)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        IOmNavigator clientInformation
        {
            [DispId(1161)]
            get;
        }

        bool closed
        {
            [DispId(23)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        string defaultStatus
        {
            [DispId(1101)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1101)]
            set;
        }

        IHTMLDocument2 document
        {
            [DispId(1151)]
            get;
        }

        IHTMLEventObj eventName
        {
            [DispId(1152)]
            get;
        }

        object external
        {
            [DispId(1169)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLFramesCollection2 frames
        {
            [DispId(1100)]
            get;
        }

        IOmHistory history
        {
            [DispId(2)]
            get;
        }

        IHTMLImageElementFactory Image
        {
            [DispId(1125)]
            get;
        }

        int length
        {
            [DispId(1001)]
            get;
        }

        IHTMLLocation location
        {
            [DispId(14)]
            get;
        }

        string name
        {
            [DispId(11)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(11)]
            set;
        }

        IOmNavigator navigator
        {
            [DispId(5)]
            get;
        }

        object offscreenBuffering
        {
            [DispId(1164)]
            get;
            [DispId(1164)]
            set;
        }

        object onbeforeunload
        {
            [DispId(-2147412073)]
            get;
            [DispId(-2147412073)]
            set;
        }

        object onblur
        {
            [DispId(-2147412097)]
            get;
            [DispId(-2147412097)]
            set;
        }

        object onerror
        {
            [DispId(-2147412083)]
            get;
            [DispId(-2147412083)]
            set;
        }

        object onfocus
        {
            [DispId(-2147412098)]
            get;
            [DispId(-2147412098)]
            set;
        }

        object onhelp
        {
            [DispId(-2147412099)]
            get;
            [DispId(-2147412099)]
            set;
        }

        object onload
        {
            [DispId(-2147412080)]
            get;
            [DispId(-2147412080)]
            set;
        }

        object onresize
        {
            [DispId(-2147412076)]
            get;
            [DispId(-2147412076)]
            set;
        }

        object onscroll
        {
            [DispId(-2147412081)]
            get;
            [DispId(-2147412081)]
            set;
        }

        object onunload
        {
            [DispId(-2147412079)]
            get;
            [DispId(-2147412079)]
            set;
        }

        object opener
        {
            [DispId(4)]
            get;
            [DispId(4)]
            set;
        }

        IHTMLOptionElementFactory Option
        {
            [DispId(1157)]
            get;
        }

        IHTMLWindow2 parent
        {
            [DispId(12)]
            get;
        }

        IHTMLScreen screen
        {
            [DispId(1156)]
            get;
        }

        IHTMLWindow2 self
        {
            [DispId(20)]
            get;
        }

        string status
        {
            [DispId(1102)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1102)]
            set;
        }

        IHTMLWindow2 top
        {
            [DispId(21)]
            get;
        }

        IHTMLWindow2 window
        {
            [DispId(22)]
            get;
        }
    }

    [Guid("3050F35C-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLScreen
    {
        int availHeight
        {
            [DispId(1006)]
            get;
        }

        int availWidth
        {
            [DispId(1007)]
            get;
        }

        int bufferDepth
        {
            [DispId(1002)]
            get;
            [DispId(1002)]
            set;
        }

        int colorDepth
        {
            [DispId(1001)]
            get;
        }

        bool fontSmoothingEnabled
        {
            [DispId(1008)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        int height
        {
            [DispId(1004)]
            get;
        }

        int updateInterval
        {
            [DispId(1005)]
            get;
            [DispId(1005)]
            set;
        }

        int width
        {
            [DispId(1003)]
            get;
        }
    }


    [Guid("3050F38C-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("create")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLOptionElementFactory
    {
        [DispId(0)]
        IHTMLOptionElement create(object text, object value, object defaultSelected, object selected);
    }



    [Guid("3050F211-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLOptionElement
    {
        bool defaultSelected
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1003)]
            set;
        }

        IHTMLFormElement form
        {
            [DispId(1006)]
            get;
        }

        int index
        {
            [DispId(1005)]
            get;
            [DispId(1005)]
            set;
        }

        bool selected
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1001)]
            set;
        }

        string text
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1004)]
            set;
        }

        string value
        {
            [DispId(1002)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1002)]
            set;
        }
    }


    [Guid("3050F1F7-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLFormElement : System.Collections.IEnumerable
    {
        [DispId(1009)]
        void submit();

        [DispId(1010)]
        void reset();

        [DispId(0)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object item(object name, object index);

        [DispId(1502)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object tags(object tagName);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        string action
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1001)]
            set;
        }

        string dir
        {
            [DispId(-2147412995)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412995)]
            set;
        }

        object elements
        {
            [DispId(1005)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string encoding
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1003)]
            set;
        }

        int length
        {
            [DispId(1500)]
            get;
            [DispId(1500)]
            set;
        }

        string method
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1004)]
            set;
        }

        string name
        {
            [DispId(-2147418112)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418112)]
            set;
        }

        object onreset
        {
            [DispId(-2147412100)]
            get;
            [DispId(-2147412100)]
            set;
        }

        object onsubmit
        {
            [DispId(-2147412101)]
            get;
            [DispId(-2147412101)]
            set;
        }

        string target
        {
            [DispId(1006)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1006)]
            set;
        }
    }


    [Guid("FECEAAA5-8405-11CF-8BA1-00AA00476DA6")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IOmNavigator
    {
        [DispId(5)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool javaEnabled();

        [DispId(6)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool taintEnabled();

        [DispId(11)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        string appCodeName
        {
            [DispId(1)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string appMinorVersion
        {
            [DispId(17)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string appName
        {
            [DispId(2)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string appVersion
        {
            [DispId(3)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string browserLanguage
        {
            [DispId(14)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int connectionSpeed
        {
            [DispId(18)]
            get;
        }

        bool cookieEnabled
        {
            [DispId(9)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        string cpuClass
        {
            [DispId(12)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLMimeTypesCollection mimeTypes
        {
            [DispId(7)]
            get;
        }

        bool onLine
        {
            [DispId(19)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        IHTMLOpsProfile opsProfile
        {
            [DispId(10)]
            get;
        }

        string platform
        {
            [DispId(16)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLPluginsCollection plugins
        {
            [DispId(8)]
            get;
        }

        string systemLanguage
        {
            [DispId(13)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string userAgent
        {
            [DispId(4)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string userLanguage
        {
            [DispId(15)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLOpsProfile userProfile
        {
            [DispId(20)]
            get;
        }
    }
    [Guid("3050F401-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLOpsProfile
    {
        [DispId(1)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool addRequest([MarshalAs(UnmanagedType.BStr)] string name, object reserved);

        [DispId(2)]
        void clearRequest();

        [DispId(3)]
        void doRequest(object usage, object fname, object domain, object path, object expire, object reserved);

        [DispId(4)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getAttribute([MarshalAs(UnmanagedType.BStr)] string name);

        [DispId(5)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool setAttribute([MarshalAs(UnmanagedType.BStr)] string name, [MarshalAs(UnmanagedType.BStr)] string value, object prefs);

        [DispId(6)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool commitChanges();

        [DispId(7)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool addReadRequest([MarshalAs(UnmanagedType.BStr)] string name, object reserved);

        [DispId(8)]
        void doReadRequest(object usage, object fname, object domain, object path, object expire, object reserved);

        [DispId(9)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool doWriteRequest();
    }



    [Guid("3050F3FD-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLPluginsCollection
    {
        [DispId(2)]
        void refresh([MarshalAs(UnmanagedType.VariantBool)] bool reload);

        int length
        {
            [DispId(1)]
            get;
        }
    }

    [Guid("3050F3FC-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLMimeTypesCollection
    {
        int length
        {
            [DispId(1)]
            get;
        }
    }


    [Guid("163BB1E0-6E00-11CF-837A-48DC04C10000")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("href")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLLocation
    {
        [DispId(8)]
        void reload([MarshalAs(UnmanagedType.VariantBool)] bool flag);

        [DispId(9)]
        void replace([MarshalAs(UnmanagedType.BStr)] string bstr);

        [DispId(10)]
        void assign([MarshalAs(UnmanagedType.BStr)] string bstr);

        [DispId(11)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        string hash
        {
            [DispId(7)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(7)]
            set;
        }

        string host
        {
            [DispId(2)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2)]
            set;
        }

        string hostname
        {
            [DispId(3)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(3)]
            set;
        }

        string href
        {
            [DispId(0)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(0)]
            set;
        }

        string pathname
        {
            [DispId(5)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(5)]
            set;
        }

        string port
        {
            [DispId(4)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(4)]
            set;
        }

        string protocol
        {
            [DispId(1)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1)]
            set;
        }

        string search
        {
            [DispId(6)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(6)]
            set;
        }
    }

    [Guid("3050F38E-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("create")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLImageElementFactory
    {
        [DispId(0)]
        IHTMLImgElement create(object width, object height);
    }


    [Guid("3050F240-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLImgElement
    {
        string align
        {
            [DispId(-2147418039)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418039)]
            set;
        }

        string alt
        {
            [DispId(1002)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1002)]
            set;
        }

        object border
        {
            [DispId(1004)]
            get;
            [DispId(1004)]
            set;
        }

        bool complete
        {
            [DispId(1010)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        string dynsrc
        {
            [DispId(1009)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1009)]
            set;
        }

        string fileCreatedDate
        {
            [DispId(2012)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileModifiedDate
        {
            [DispId(2013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileSize
        {
            [DispId(2011)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileUpdatedDate
        {
            [DispId(2014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int height
        {
            [DispId(-2147418106)]
            get;
            [DispId(-2147418106)]
            set;
        }

        string href
        {
            [DispId(2016)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int hspace
        {
            [DispId(1006)]
            get;
            [DispId(1006)]
            set;
        }

        bool isMap
        {
            [DispId(2002)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2002)]
            set;
        }

        object loop
        {
            [DispId(1011)]
            get;
            [DispId(1011)]
            set;
        }

        string lowsrc
        {
            [DispId(1007)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1007)]
            set;
        }

        string mimeType
        {
            [DispId(2010)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string name
        {
            [DispId(-2147418112)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418112)]
            set;
        }

        string nameProp
        {
            [DispId(2017)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object onabort
        {
            [DispId(-2147412084)]
            get;
            [DispId(-2147412084)]
            set;
        }

        object onerror
        {
            [DispId(-2147412083)]
            get;
            [DispId(-2147412083)]
            set;
        }

        object onload
        {
            [DispId(-2147412080)]
            get;
            [DispId(-2147412080)]
            set;
        }

        string protocol
        {
            [DispId(2015)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string readyState
        {
            [DispId(-2147412996)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string src
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1003)]
            set;
        }

        string Start
        {
            [DispId(1013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1013)]
            set;
        }

        string useMap
        {
            [DispId(2008)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2008)]
            set;
        }

        string vrml
        {
            [DispId(1008)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1008)]
            set;
        }

        int vspace
        {
            [DispId(1005)]
            get;
            [DispId(1005)]
            set;
        }

        int width
        {
            [DispId(-2147418107)]
            get;
            [DispId(-2147418107)]
            set;
        }
    }


    [Guid("3051040C-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("create")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLXMLHttpRequestFactory
    {
        [DispId(0)]
        IHTMLXMLHttpRequest create();
    }

    [Guid("FECEAAA2-8405-11CF-8BA1-00AA00476DA6")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IOmHistory
    {
        [DispId(2)]
        void back([In] ref object pvargdistance);

        [DispId(3)]
        void forward([In] ref object pvargdistance);

        [DispId(4)]
        void go([In] ref object pvargdistance);

        short length
        {
            [DispId(1)]
            get;
        }
    }


    [Guid("3051040A-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLXMLHttpRequest
    {
        [DispId(1009)]
        void abort();

        [DispId(1010)]
        void open([MarshalAs(UnmanagedType.BStr)] string bstrMethod, [MarshalAs(UnmanagedType.BStr)] string bstrUrl, object varAsync, object varUser, object varPassword);

        [DispId(1011)]
        void send(object varBody);

        [DispId(1012)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getAllResponseHeaders();

        [DispId(1013)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getResponseHeader([MarshalAs(UnmanagedType.BStr)] string bstrHeader);

        [DispId(1014)]
        void setRequestHeader([MarshalAs(UnmanagedType.BStr)] string bstrHeader, [MarshalAs(UnmanagedType.BStr)] string bstrValue);

        object onreadystatechange
        {
            [DispId(1008)]
            get;
            [DispId(1008)]
            set;
        }

        int readyState
        {
            [DispId(1002)]
            get;
        }

        object responseBody
        {
            [DispId(1003)]
            get;
        }

        string responseText
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object responseXML
        {
            [DispId(1005)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        int status
        {
            [DispId(1006)]
            get;
        }

        string statusText
        {
            [DispId(1007)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }
    }



    [Guid("332C4426-26CB-11D0-B483-00C04FD90119")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLFramesCollection2
    {
        [DispId(0)]
        object item([In] ref object pvarIndex);

        int length
        {
            [DispId(1001)]
            get;
        }
    }

    [Guid("3050F32D-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLEventObj
    {
        bool altKey
        {
            [DispId(1002)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        int button
        {
            [DispId(1012)]
            get;
        }

        bool cancelBubble
        {
            [DispId(1008)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1008)]
            set;
        }

        int clientX
        {
            [DispId(1020)]
            get;
        }

        int clientY
        {
            [DispId(1021)]
            get;
        }

        bool ctrlKey
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        IHTMLElement fromElement
        {
            [DispId(1009)]
            get;
        }

        int keyCode
        {
            [DispId(1011)]
            get;
            [DispId(1011)]
            set;
        }

        int offsetX
        {
            [DispId(1022)]
            get;
        }

        int offsetY
        {
            [DispId(1023)]
            get;
        }

        string qualifier
        {
            [DispId(1014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int reason
        {
            [DispId(1015)]
            get;
        }

        object returnValue
        {
            [DispId(1007)]
            get;
            [DispId(1007)]
            set;
        }

        int screenX
        {
            [DispId(1024)]
            get;
        }

        int screenY
        {
            [DispId(1025)]
            get;
        }

        bool shiftKey
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        IHTMLElement srcElement
        {
            [DispId(1001)]
            get;
        }

        object srcFilter
        {
            [DispId(1026)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLElement toElement
        {
            [DispId(1010)]
            get;
        }

        string type
        {
            [DispId(1013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int x
        {
            [DispId(1005)]
            get;
        }

        int y
        {
            [DispId(1006)]
            get;
        }
    }



    [Guid("332C4425-26CB-11D0-B483-00C04FD90119")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDocument2
    {
        [DispId(1054)]
        void write([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] object[] psarray);

        [DispId(1055)]
        void writeln([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] object[] psarray);

        [DispId(1056)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object open([MarshalAs(UnmanagedType.BStr)] string url, object name, object features, object replace);

        [DispId(1057)]
        void close();

        [DispId(1058)]
        void clear();

        [DispId(1059)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandSupported([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1060)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandEnabled([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1061)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandState([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1062)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandIndeterm([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1063)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string queryCommandText([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1064)]
        object queryCommandValue([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1065)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommand([MarshalAs(UnmanagedType.BStr)] string cmdID, [MarshalAs(UnmanagedType.VariantBool)] bool showUI, object value);

        [DispId(1066)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommandShowHelp([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1067)]
        IHTMLElement createElement([MarshalAs(UnmanagedType.BStr)] string eTag);

        [DispId(1068)]
        IHTMLElement elementFromPoint(int x, int y);

        [DispId(1070)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        [DispId(1071)]
        IHTMLStyleSheet createStyleSheet([MarshalAs(UnmanagedType.BStr)] string bstrHref, int lIndex);

        IHTMLElement activeElement
        {
            [DispId(1005)]
            get;
        }

        object alinkColor
        {
            [DispId(1022)]
            get;
            [DispId(1022)]
            set;
        }

        IHTMLElementCollection all
        {
            [DispId(1003)]
            get;
        }

        IHTMLElementCollection anchors
        {
            [DispId(1007)]
            get;
        }

        IHTMLElementCollection applets
        {
            [DispId(1008)]
            get;
        }

        object bgColor
        {
            [DispId(-501)]
            get;
            [DispId(-501)]
            set;
        }

        IHTMLElement body
        {
            [DispId(1004)]
            get;
        }

        string charset
        {
            [DispId(1032)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1032)]
            set;
        }

        string cookie
        {
            [DispId(1030)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1030)]
            set;
        }

        string defaultCharset
        {
            [DispId(1033)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1033)]
            set;
        }

        string designMode
        {
            [DispId(1014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1014)]
            set;
        }

        string domain
        {
            [DispId(1029)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1029)]
            set;
        }

        IHTMLElementCollection embeds
        {
            [DispId(1015)]
            get;
        }

        bool expando
        {
            [DispId(1031)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(1031)]
            set;
        }

        object fgColor
        {
            [DispId(-2147413110)]
            get;
            [DispId(-2147413110)]
            set;
        }

        string fileCreatedDate
        {
            [DispId(1043)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileModifiedDate
        {
            [DispId(1044)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileSize
        {
            [DispId(1042)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fileUpdatedDate
        {
            [DispId(1045)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLElementCollection forms
        {
            [DispId(1010)]
            get;
        }

        IHTMLFramesCollection2 frames
        {
            [DispId(1019)]
            get;
        }

        IHTMLElementCollection images
        {
            [DispId(1011)]
            get;
        }

        string lastModified
        {
            [DispId(1028)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object linkColor
        {
            [DispId(1024)]
            get;
            [DispId(1024)]
            set;
        }

        IHTMLElementCollection links
        {
            [DispId(1009)]
            get;
        }

        IHTMLLocation location
        {
            [DispId(1026)]
            get;
        }

        string mimeType
        {
            [DispId(1041)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string nameProp
        {
            [DispId(1048)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object onafterupdate
        {
            [DispId(-2147412090)]
            get;
            [DispId(-2147412090)]
            set;
        }

        object onbeforeupdate
        {
            [DispId(-2147412091)]
            get;
            [DispId(-2147412091)]
            set;
        }

        object onclick
        {
            [DispId(-2147412104)]
            get;
            [DispId(-2147412104)]
            set;
        }

        object ondblclick
        {
            [DispId(-2147412103)]
            get;
            [DispId(-2147412103)]
            set;
        }

        object ondragstart
        {
            [DispId(-2147412077)]
            get;
            [DispId(-2147412077)]
            set;
        }

        object onerrorupdate
        {
            [DispId(-2147412074)]
            get;
            [DispId(-2147412074)]
            set;
        }

        object onhelp
        {
            [DispId(-2147412099)]
            get;
            [DispId(-2147412099)]
            set;
        }

        object onkeydown
        {
            [DispId(-2147412107)]
            get;
            [DispId(-2147412107)]
            set;
        }

        object onkeypress
        {
            [DispId(-2147412105)]
            get;
            [DispId(-2147412105)]
            set;
        }

        object onkeyup
        {
            [DispId(-2147412106)]
            get;
            [DispId(-2147412106)]
            set;
        }

        object onmousedown
        {
            [DispId(-2147412110)]
            get;
            [DispId(-2147412110)]
            set;
        }

        object onmousemove
        {
            [DispId(-2147412108)]
            get;
            [DispId(-2147412108)]
            set;
        }

        object onmouseout
        {
            [DispId(-2147412111)]
            get;
            [DispId(-2147412111)]
            set;
        }

        object onmouseover
        {
            [DispId(-2147412112)]
            get;
            [DispId(-2147412112)]
            set;
        }

        object onmouseup
        {
            [DispId(-2147412109)]
            get;
            [DispId(-2147412109)]
            set;
        }

        object onreadystatechange
        {
            [DispId(-2147412087)]
            get;
            [DispId(-2147412087)]
            set;
        }

        object onrowenter
        {
            [DispId(-2147412093)]
            get;
            [DispId(-2147412093)]
            set;
        }

        object onrowexit
        {
            [DispId(-2147412094)]
            get;
            [DispId(-2147412094)]
            set;
        }

        object onselectstart
        {
            [DispId(-2147412075)]
            get;
            [DispId(-2147412075)]
            set;
        }

        IHTMLWindow2 parentWindow
        {
            [DispId(1034)]
            get;
        }

        IHTMLElementCollection plugins
        {
            [DispId(1021)]
            get;
        }

        string protocol
        {
            [DispId(1047)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string readyState
        {
            [DispId(1018)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string referrer
        {
            [DispId(1027)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object Script
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLElementCollection scripts
        {
            [DispId(1013)]
            get;
        }

        string security
        {
            [DispId(1046)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLSelectionObject selection
        {
            [DispId(1017)]
            get;
        }

        IHTMLStyleSheetsCollection styleSheets
        {
            [DispId(1069)]
            get;
        }

        string title
        {
            [DispId(1012)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1012)]
            set;
        }

        string url
        {
            [DispId(1025)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1025)]
            set;
        }

        object vlinkColor
        {
            [DispId(1023)]
            get;
            [DispId(1023)]
            set;
        }
    }


    [Guid("3050F80D-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDOMImplementation
    {
        [DispId(1000)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasFeature([MarshalAs(UnmanagedType.BStr)] string bstrfeature, object version);
    }

    [Guid("30510418-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDocumentCompatibleInfoCollection
    {
        [DispId(0)]
        IHTMLDocumentCompatibleInfo item(int index);

        int length
        {
            [DispId(1001)]
            get;
        }
    }

    [Guid("3051041A-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDocumentCompatibleInfo
    {
        string userAgent
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string version
        {
            [DispId(1002)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }
    }


    [Guid("3050F5AB-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDOMChildrenCollection : System.Collections.IEnumerable
    {
        [DispId(0)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object item(int index);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        int length
        {
            [DispId(1500)]
            get;
        }
    }

    [Guid("3050F434-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLElement2
    {
        [DispId(-2147417072)]
        void setCapture([MarshalAs(UnmanagedType.VariantBool)] bool containerCapture);

        [DispId(-2147417071)]
        void releaseCapture();

        [DispId(-2147417070)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string componentFromPoint(int x, int y);

        [DispId(-2147417069)]
        void doScroll(object component);

        [DispId(-2147417068)]
        IHTMLRectCollection getClientRects();

        [DispId(-2147417067)]
        IHTMLRect getBoundingClientRect();

        [DispId(-2147417608)]
        void setExpression([MarshalAs(UnmanagedType.BStr)] string propname, [MarshalAs(UnmanagedType.BStr)] string expression, [MarshalAs(UnmanagedType.BStr)] string language);

        [DispId(-2147417607)]
        object getExpression([MarshalAs(UnmanagedType.BStr)] string propname);

        [DispId(-2147417606)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeExpression([MarshalAs(UnmanagedType.BStr)] string propname);

        [DispId(-2147416112)]
        void focus();

        [DispId(-2147416110)]
        void blur();

        [DispId(-2147416095)]
        void addFilter([MarshalAs(UnmanagedType.IUnknown)] object pUnk);

        [DispId(-2147416094)]
        void removeFilter([MarshalAs(UnmanagedType.IUnknown)] object pUnk);

        [DispId(-2147417605)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool attachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(-2147417604)]
        void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(-2147417056)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object createControlRange();

        [DispId(-2147417050)]
        void clearAttributes();

        [DispId(-2147417049)]
        void mergeAttributes(IHTMLElement mergeThis);

        [DispId(-2147417043)]
        IHTMLElement insertAdjacentElement([MarshalAs(UnmanagedType.BStr)] string where, IHTMLElement insertedElement);

        [DispId(-2147417047)]
        IHTMLElement applyElement(IHTMLElement apply, [MarshalAs(UnmanagedType.BStr)] string where);

        [DispId(-2147417042)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getAdjacentText([MarshalAs(UnmanagedType.BStr)] string where);

        [DispId(-2147417041)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string replaceAdjacentText([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string newText);

        [DispId(-2147417032)]
        int addBehavior([MarshalAs(UnmanagedType.BStr)] string bstrUrl, [In] ref object pvarFactory);

        [DispId(-2147417031)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeBehavior(int cookie);

        [DispId(-2147417027)]
        IHTMLElementCollection getElementsByTagName([MarshalAs(UnmanagedType.BStr)] string v);

        string accessKey
        {
            [DispId(-2147416107)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416107)]
            set;
        }

        object behaviorUrns
        {
            [DispId(-2147417030)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        bool canHaveChildren
        {
            [DispId(-2147417040)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        int clientHeight
        {
            [DispId(-2147416093)]
            get;
        }

        int clientLeft
        {
            [DispId(-2147416090)]
            get;
        }

        int clientTop
        {
            [DispId(-2147416091)]
            get;
        }

        int clientWidth
        {
            [DispId(-2147416092)]
            get;
        }

        IHTMLCurrentStyle currentStyle
        {
            [DispId(-2147417105)]
            get;
        }

        string dir
        {
            [DispId(-2147412995)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412995)]
            set;
        }

        object onbeforecopy
        {
            [DispId(-2147412053)]
            get;
            [DispId(-2147412053)]
            set;
        }

        object onbeforecut
        {
            [DispId(-2147412054)]
            get;
            [DispId(-2147412054)]
            set;
        }

        object onbeforeeditfocus
        {
            [DispId(-2147412043)]
            get;
            [DispId(-2147412043)]
            set;
        }

        object onbeforepaste
        {
            [DispId(-2147412052)]
            get;
            [DispId(-2147412052)]
            set;
        }

        object onblur
        {
            [DispId(-2147412097)]
            get;
            [DispId(-2147412097)]
            set;
        }

        object oncellchange
        {
            [DispId(-2147412048)]
            get;
            [DispId(-2147412048)]
            set;
        }

        object oncontextmenu
        {
            [DispId(-2147412047)]
            get;
            [DispId(-2147412047)]
            set;
        }

        object oncopy
        {
            [DispId(-2147412056)]
            get;
            [DispId(-2147412056)]
            set;
        }

        object oncut
        {
            [DispId(-2147412057)]
            get;
            [DispId(-2147412057)]
            set;
        }

        object ondrag
        {
            [DispId(-2147412063)]
            get;
            [DispId(-2147412063)]
            set;
        }

        object ondragend
        {
            [DispId(-2147412062)]
            get;
            [DispId(-2147412062)]
            set;
        }

        object ondragenter
        {
            [DispId(-2147412061)]
            get;
            [DispId(-2147412061)]
            set;
        }

        object ondragleave
        {
            [DispId(-2147412059)]
            get;
            [DispId(-2147412059)]
            set;
        }

        object ondragover
        {
            [DispId(-2147412060)]
            get;
            [DispId(-2147412060)]
            set;
        }

        object ondrop
        {
            [DispId(-2147412058)]
            get;
            [DispId(-2147412058)]
            set;
        }

        object onfocus
        {
            [DispId(-2147412098)]
            get;
            [DispId(-2147412098)]
            set;
        }

        object onlosecapture
        {
            [DispId(-2147412066)]
            get;
            [DispId(-2147412066)]
            set;
        }

        object onpaste
        {
            [DispId(-2147412055)]
            get;
            [DispId(-2147412055)]
            set;
        }

        object onpropertychange
        {
            [DispId(-2147412065)]
            get;
            [DispId(-2147412065)]
            set;
        }

        object onreadystatechange
        {
            [DispId(-2147412087)]
            get;
            [DispId(-2147412087)]
            set;
        }

        object onresize
        {
            [DispId(-2147412076)]
            get;
            [DispId(-2147412076)]
            set;
        }

        object onrowsdelete
        {
            [DispId(-2147412050)]
            get;
            [DispId(-2147412050)]
            set;
        }

        object onrowsinserted
        {
            [DispId(-2147412049)]
            get;
            [DispId(-2147412049)]
            set;
        }

        object onscroll
        {
            [DispId(-2147412081)]
            get;
            [DispId(-2147412081)]
            set;
        }

        object readyState
        {
            [DispId(-2147412996)]
            get;
        }

        int readyStateValue
        {
            [DispId(-2147417028)]
            get;
        }

        IHTMLStyle runtimeStyle
        {
            [DispId(-2147417048)]
            get;
        }

        string scopeName
        {
            [DispId(-2147417073)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int scrollHeight
        {
            [DispId(-2147417055)]
            get;
        }

        int scrollLeft
        {
            [DispId(-2147417052)]
            get;
            [DispId(-2147417052)]
            set;
        }

        int scrollTop
        {
            [DispId(-2147417053)]
            get;
            [DispId(-2147417053)]
            set;
        }

        int scrollWidth
        {
            [DispId(-2147417054)]
            get;
        }

        short tabIndex
        {
            [DispId(-2147418097)]
            get;
            [DispId(-2147418097)]
            set;
        }

        string tagUrn
        {
            [DispId(-2147417029)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417029)]
            set;
        }
    }

    [Guid("3050F25E-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLStyle
    {
        [DispId(-2147417611)]
        void setAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, object AttributeValue, int lFlags);

        [DispId(-2147417610)]
        object getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417609)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147414104)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        string background
        {
            [DispId(-2147413080)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413080)]
            set;
        }

        string backgroundAttachment
        {
            [DispId(-2147413067)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413067)]
            set;
        }

        object backgroundColor
        {
            [DispId(-501)]
            get;
            [DispId(-501)]
            set;
        }

        string backgroundImage
        {
            [DispId(-2147413111)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413111)]
            set;
        }

        string backgroundPosition
        {
            [DispId(-2147413066)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413066)]
            set;
        }

        object backgroundPositionX
        {
            [DispId(-2147413079)]
            get;
            [DispId(-2147413079)]
            set;
        }

        object backgroundPositionY
        {
            [DispId(-2147413078)]
            get;
            [DispId(-2147413078)]
            set;
        }

        string backgroundRepeat
        {
            [DispId(-2147413068)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413068)]
            set;
        }

        string border
        {
            [DispId(-2147413063)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413063)]
            set;
        }

        string borderBottom
        {
            [DispId(-2147413060)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413060)]
            set;
        }

        object borderBottomColor
        {
            [DispId(-2147413055)]
            get;
            [DispId(-2147413055)]
            set;
        }

        string borderBottomStyle
        {
            [DispId(-2147413045)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413045)]
            set;
        }

        object borderBottomWidth
        {
            [DispId(-2147413050)]
            get;
            [DispId(-2147413050)]
            set;
        }

        string borderColor
        {
            [DispId(-2147413058)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413058)]
            set;
        }

        string borderLeft
        {
            [DispId(-2147413059)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413059)]
            set;
        }

        object borderLeftColor
        {
            [DispId(-2147413054)]
            get;
            [DispId(-2147413054)]
            set;
        }

        string borderLeftStyle
        {
            [DispId(-2147413044)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413044)]
            set;
        }

        object borderLeftWidth
        {
            [DispId(-2147413049)]
            get;
            [DispId(-2147413049)]
            set;
        }

        string borderRight
        {
            [DispId(-2147413061)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413061)]
            set;
        }

        object borderRightColor
        {
            [DispId(-2147413056)]
            get;
            [DispId(-2147413056)]
            set;
        }

        string borderRightStyle
        {
            [DispId(-2147413046)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413046)]
            set;
        }

        object borderRightWidth
        {
            [DispId(-2147413051)]
            get;
            [DispId(-2147413051)]
            set;
        }

        string borderStyle
        {
            [DispId(-2147413048)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413048)]
            set;
        }

        string borderTop
        {
            [DispId(-2147413062)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413062)]
            set;
        }

        object borderTopColor
        {
            [DispId(-2147413057)]
            get;
            [DispId(-2147413057)]
            set;
        }

        string borderTopStyle
        {
            [DispId(-2147413047)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413047)]
            set;
        }

        object borderTopWidth
        {
            [DispId(-2147413052)]
            get;
            [DispId(-2147413052)]
            set;
        }

        string borderWidth
        {
            [DispId(-2147413053)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413053)]
            set;
        }

        string clear
        {
            [DispId(-2147413096)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413096)]
            set;
        }

        string clip
        {
            [DispId(-2147413020)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413020)]
            set;
        }

        object color
        {
            [DispId(-2147413110)]
            get;
            [DispId(-2147413110)]
            set;
        }

        string cssText
        {
            [DispId(-2147413013)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413013)]
            set;
        }

        string cursor
        {
            [DispId(-2147413010)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413010)]
            set;
        }

        string display
        {
            [DispId(-2147413041)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413041)]
            set;
        }

        string filter
        {
            [DispId(-2147413030)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413030)]
            set;
        }

        string font
        {
            [DispId(-2147413071)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413071)]
            set;
        }

        string fontFamily
        {
            [DispId(-2147413094)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413094)]
            set;
        }

        object fontSize
        {
            [DispId(-2147413093)]
            get;
            [DispId(-2147413093)]
            set;
        }

        string fontStyle
        {
            [DispId(-2147413088)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413088)]
            set;
        }

        string fontVariant
        {
            [DispId(-2147413087)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413087)]
            set;
        }

        string fontWeight
        {
            [DispId(-2147413085)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413085)]
            set;
        }

        object height
        {
            [DispId(-2147418106)]
            get;
            [DispId(-2147418106)]
            set;
        }

        object left
        {
            [DispId(-2147418109)]
            get;
            [DispId(-2147418109)]
            set;
        }

        object letterSpacing
        {
            [DispId(-2147413104)]
            get;
            [DispId(-2147413104)]
            set;
        }

        object lineHeight
        {
            [DispId(-2147413106)]
            get;
            [DispId(-2147413106)]
            set;
        }

        string listStyle
        {
            [DispId(-2147413037)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413037)]
            set;
        }

        string listStyleImage
        {
            [DispId(-2147413038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413038)]
            set;
        }

        string listStylePosition
        {
            [DispId(-2147413039)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413039)]
            set;
        }

        string listStyleType
        {
            [DispId(-2147413040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413040)]
            set;
        }

        string margin
        {
            [DispId(-2147413076)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413076)]
            set;
        }

        object marginBottom
        {
            [DispId(-2147413073)]
            get;
            [DispId(-2147413073)]
            set;
        }

        object marginLeft
        {
            [DispId(-2147413072)]
            get;
            [DispId(-2147413072)]
            set;
        }

        object marginRight
        {
            [DispId(-2147413074)]
            get;
            [DispId(-2147413074)]
            set;
        }

        object marginTop
        {
            [DispId(-2147413075)]
            get;
            [DispId(-2147413075)]
            set;
        }

        string overflow
        {
            [DispId(-2147413102)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413102)]
            set;
        }

        string padding
        {
            [DispId(-2147413101)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413101)]
            set;
        }

        object paddingBottom
        {
            [DispId(-2147413098)]
            get;
            [DispId(-2147413098)]
            set;
        }

        object paddingLeft
        {
            [DispId(-2147413097)]
            get;
            [DispId(-2147413097)]
            set;
        }

        object paddingRight
        {
            [DispId(-2147413099)]
            get;
            [DispId(-2147413099)]
            set;
        }

        object paddingTop
        {
            [DispId(-2147413100)]
            get;
            [DispId(-2147413100)]
            set;
        }

        string pageBreakAfter
        {
            [DispId(-2147413034)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413034)]
            set;
        }

        string pageBreakBefore
        {
            [DispId(-2147413035)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413035)]
            set;
        }

        int pixelHeight
        {
            [DispId(-2147414109)]
            get;
            [DispId(-2147414109)]
            set;
        }

        int pixelLeft
        {
            [DispId(-2147414111)]
            get;
            [DispId(-2147414111)]
            set;
        }

        int pixelTop
        {
            [DispId(-2147414112)]
            get;
            [DispId(-2147414112)]
            set;
        }

        int pixelWidth
        {
            [DispId(-2147414110)]
            get;
            [DispId(-2147414110)]
            set;
        }

        float posHeight
        {
            [DispId(-2147414105)]
            get;
            [DispId(-2147414105)]
            set;
        }

        string position
        {
            [DispId(-2147413022)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        float posLeft
        {
            [DispId(-2147414107)]
            get;
            [DispId(-2147414107)]
            set;
        }

        float posTop
        {
            [DispId(-2147414108)]
            get;
            [DispId(-2147414108)]
            set;
        }

        float posWidth
        {
            [DispId(-2147414106)]
            get;
            [DispId(-2147414106)]
            set;
        }

        string styleFloat
        {
            [DispId(-2147413042)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413042)]
            set;
        }

        string textAlign
        {
            [DispId(-2147418040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418040)]
            set;
        }

        string textDecoration
        {
            [DispId(-2147413077)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413077)]
            set;
        }

        bool textDecorationBlink
        {
            [DispId(-2147413090)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413090)]
            set;
        }

        bool textDecorationLineThrough
        {
            [DispId(-2147413092)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413092)]
            set;
        }

        bool textDecorationNone
        {
            [DispId(-2147413089)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413089)]
            set;
        }

        bool textDecorationOverline
        {
            [DispId(-2147413043)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413043)]
            set;
        }

        bool textDecorationUnderline
        {
            [DispId(-2147413091)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147413091)]
            set;
        }

        object textIndent
        {
            [DispId(-2147413105)]
            get;
            [DispId(-2147413105)]
            set;
        }

        string textTransform
        {
            [DispId(-2147413108)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413108)]
            set;
        }

        object top
        {
            [DispId(-2147418108)]
            get;
            [DispId(-2147418108)]
            set;
        }

        object verticalAlign
        {
            [DispId(-2147413064)]
            get;
            [DispId(-2147413064)]
            set;
        }

        string visibility
        {
            [DispId(-2147413032)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413032)]
            set;
        }

        string whiteSpace
        {
            [DispId(-2147413036)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413036)]
            set;
        }

        object width
        {
            [DispId(-2147418107)]
            get;
            [DispId(-2147418107)]
            set;
        }

        object wordSpacing
        {
            [DispId(-2147413065)]
            get;
            [DispId(-2147413065)]
            set;
        }

        object zIndex
        {
            [DispId(-2147413021)]
            get;
            [DispId(-2147413021)]
            set;
        }
    }

    [Guid("3050F3DB-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLCurrentStyle
    {
        [DispId(-2147417610)]
        object getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        string accelerator
        {
            [DispId(-2147412965)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string backgroundAttachment
        {
            [DispId(-2147413067)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object backgroundColor
        {
            [DispId(-501)]
            get;
        }

        string backgroundImage
        {
            [DispId(-2147413111)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object backgroundPositionX
        {
            [DispId(-2147413079)]
            get;
        }

        object backgroundPositionY
        {
            [DispId(-2147413078)]
            get;
        }

        string backgroundRepeat
        {
            [DispId(-2147413068)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string behavior
        {
            [DispId(-2147412997)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string blockDirection
        {
            [DispId(-2147412995)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderBottomColor
        {
            [DispId(-2147413055)]
            get;
        }

        string borderBottomStyle
        {
            [DispId(-2147413045)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderBottomWidth
        {
            [DispId(-2147413050)]
            get;
        }

        string borderCollapse
        {
            [DispId(-2147413028)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string borderColor
        {
            [DispId(-2147413058)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderLeftColor
        {
            [DispId(-2147413054)]
            get;
        }

        string borderLeftStyle
        {
            [DispId(-2147413044)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderLeftWidth
        {
            [DispId(-2147413049)]
            get;
        }

        object borderRightColor
        {
            [DispId(-2147413056)]
            get;
        }

        string borderRightStyle
        {
            [DispId(-2147413046)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderRightWidth
        {
            [DispId(-2147413051)]
            get;
        }

        string borderStyle
        {
            [DispId(-2147413048)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderTopColor
        {
            [DispId(-2147413057)]
            get;
        }

        string borderTopStyle
        {
            [DispId(-2147413047)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object borderTopWidth
        {
            [DispId(-2147413052)]
            get;
        }

        string borderWidth
        {
            [DispId(-2147413053)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object bottom
        {
            [DispId(-2147418034)]
            get;
        }

        string clear
        {
            [DispId(-2147413096)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object clipBottom
        {
            [DispId(-2147413017)]
            get;
        }

        object clipLeft
        {
            [DispId(-2147413016)]
            get;
        }

        object clipRight
        {
            [DispId(-2147413018)]
            get;
        }

        object clipTop
        {
            [DispId(-2147413019)]
            get;
        }

        object color
        {
            [DispId(-2147413110)]
            get;
        }

        string cursor
        {
            [DispId(-2147413010)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string direction
        {
            [DispId(-2147412993)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string display
        {
            [DispId(-2147413041)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fontFamily
        {
            [DispId(-2147413094)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object fontSize
        {
            [DispId(-2147413093)]
            get;
        }

        string fontStyle
        {
            [DispId(-2147413088)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string fontVariant
        {
            [DispId(-2147413087)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object fontWeight
        {
            [DispId(-2147413085)]
            get;
        }

        object height
        {
            [DispId(-2147418106)]
            get;
        }

        string imeMode
        {
            [DispId(-2147412992)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object layoutGridChar
        {
            [DispId(-2147412985)]
            get;
        }

        object layoutGridLine
        {
            [DispId(-2147412984)]
            get;
        }

        string layoutGridMode
        {
            [DispId(-2147412983)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string layoutGridType
        {
            [DispId(-2147412982)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object left
        {
            [DispId(-2147418109)]
            get;
        }

        object letterSpacing
        {
            [DispId(-2147413104)]
            get;
        }

        string lineBreak
        {
            [DispId(-2147412979)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object lineHeight
        {
            [DispId(-2147413106)]
            get;
        }

        string listStyleImage
        {
            [DispId(-2147413038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string listStylePosition
        {
            [DispId(-2147413039)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string listStyleType
        {
            [DispId(-2147413040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string margin
        {
            [DispId(-2147413076)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object marginBottom
        {
            [DispId(-2147413073)]
            get;
        }

        object marginLeft
        {
            [DispId(-2147413072)]
            get;
        }

        object marginRight
        {
            [DispId(-2147413074)]
            get;
        }

        object marginTop
        {
            [DispId(-2147413075)]
            get;
        }

        string overflow
        {
            [DispId(-2147413102)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string overflowX
        {
            [DispId(-2147412973)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string overflowY
        {
            [DispId(-2147412972)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string padding
        {
            [DispId(-2147413101)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object paddingBottom
        {
            [DispId(-2147413098)]
            get;
        }

        object paddingLeft
        {
            [DispId(-2147413097)]
            get;
        }

        object paddingRight
        {
            [DispId(-2147413099)]
            get;
        }

        object paddingTop
        {
            [DispId(-2147413100)]
            get;
        }

        string pageBreakAfter
        {
            [DispId(-2147413034)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string pageBreakBefore
        {
            [DispId(-2147413035)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string position
        {
            [DispId(-2147413022)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object right
        {
            [DispId(-2147418035)]
            get;
        }

        string rubyAlign
        {
            [DispId(-2147412991)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string rubyOverhang
        {
            [DispId(-2147412989)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string rubyPosition
        {
            [DispId(-2147412990)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string styleFloat
        {
            [DispId(-2147413042)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string tableLayout
        {
            [DispId(-2147413014)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string textAlign
        {
            [DispId(-2147418040)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string textAutospace
        {
            [DispId(-2147412980)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string textDecoration
        {
            [DispId(-2147413077)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object textIndent
        {
            [DispId(-2147413105)]
            get;
        }

        string textJustify
        {
            [DispId(-2147412977)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string textJustifyTrim
        {
            [DispId(-2147412976)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object textKashida
        {
            [DispId(-2147412975)]
            get;
        }

        string textTransform
        {
            [DispId(-2147413108)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object top
        {
            [DispId(-2147418108)]
            get;
        }

        string unicodeBidi
        {
            [DispId(-2147412994)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object verticalAlign
        {
            [DispId(-2147413064)]
            get;
        }

        string visibility
        {
            [DispId(-2147413032)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object width
        {
            [DispId(-2147418107)]
            get;
        }

        string wordBreak
        {
            [DispId(-2147412978)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object zIndex
        {
            [DispId(-2147413021)]
            get;
        }
    }

    [Guid("3050F4A3-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLRect
    {
        int bottom
        {
            [DispId(1004)]
            get;
            [DispId(1004)]
            set;
        }

        int left
        {
            [DispId(1001)]
            get;
            [DispId(1001)]
            set;
        }

        int right
        {
            [DispId(1003)]
            get;
            [DispId(1003)]
            set;
        }

        int top
        {
            [DispId(1002)]
            get;
            [DispId(1002)]
            set;
        }
    }

    [Guid("3050F4A4-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLRectCollection : System.Collections.IEnumerable
    {
        [DispId(0)]
        object item([In] ref object pvarIndex);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        int length
        {
            [DispId(1500)]
            get;
        }
    }


    [Guid("3050F6AE-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLRenderStyle
    {
        string defaultTextSelection
        {
            [DispId(-2147412924)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412924)]
            set;
        }

        int renderingPriority
        {
            [DispId(-2147412942)]
            get;
            [DispId(-2147412942)]
            set;
        }

        object textBackgroundColor
        {
            [DispId(-2147412943)]
            get;
            [DispId(-2147412943)]
            set;
        }

        object textColor
        {
            [DispId(-2147412922)]
            get;
            [DispId(-2147412922)]
            set;
        }

        string textDecoration
        {
            [DispId(-2147412921)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412921)]
            set;
        }

        object textDecorationColor
        {
            [DispId(-2147412923)]
            get;
            [DispId(-2147412923)]
            set;
        }

        string textEffect
        {
            [DispId(-2147412944)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412944)]
            set;
        }

        string textLineThroughStyle
        {
            [DispId(-2147412946)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412946)]
            set;
        }

        string textUnderlineStyle
        {
            [DispId(-2147412945)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412945)]
            set;
        }
    }

    [Guid("3050F4B0-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDOMAttribute
    {
        string nodeName
        {
            [DispId(1000)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        object nodeValue
        {
            [DispId(1002)]
            get;
            [DispId(1002)]
            set;
        }

        bool specified
        {
            [DispId(1001)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }
    }

    [Guid("3050F57D-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [CoClass(typeof(HTMLInputElementClass))]
    public interface HTMLInputElement : DispHTMLInputElement
    {
    }


    [Guid("3050F5D8-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)0)]
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces("HTMLInputTextElementEvents, HTMLInputTextElementEvents2, HTMLOptionButtonElementEvents, HTMLButtonElementEvents")]
    public class HTMLInputElementClass // : IHTMLElement, IHTMLElement2, IHTMLElement3, IHTMLElement4, IHTMLUniqueName, IHTMLDOMNode, IHTMLDOMNode2, IHTMLDatabinding, IHTMLElement5, IElementSelector, IHTMLDOMConstructor, IHTMLControlElement, IHTMLInputElement, IHTMLInputElement2, IHTMLInputTextElement, IHTMLInputHiddenElement, IHTMLInputButtonElement, IHTMLInputFileElement, IHTMLOptionButtonElement, IHTMLInputImage, IHTMLInputElement3, DispHTMLInputElement, HTMLInputElement, , , , HTMLInputTextElementEvents_EventHTMLInputTextElementEvents2_EventHTMLOptionButtonElementEvents_EventHTMLButtonElementEvents_Event
    {
    }


    [Guid("3050F57D-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4112)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface DispHTMLInputElement
    {
        [DispId(-2147417611)]
        void setAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, object AttributeValue, int lFlags);

        [DispId(-2147417610)]
        object getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417609)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, int lFlags);

        [DispId(-2147417093)]
        void scrollIntoView(object varargStart);

        [DispId(-2147417092)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool contains(IHTMLElement pChild);

        [DispId(-2147417082)]
        void insertAdjacentHTML([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string html);

        [DispId(-2147417081)]
        void insertAdjacentText([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string text);

        [DispId(-2147417079)]
        void click();

        [DispId(-2147417076)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string toString();

        [DispId(-2147417072)]
        void setCapture([MarshalAs(UnmanagedType.VariantBool)] bool containerCapture);

        [DispId(-2147417071)]
        void releaseCapture();

        [DispId(-2147417070)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string componentFromPoint(int x, int y);

        [DispId(-2147417069)]
        void doScroll(object component);

        [DispId(-2147417068)]
        IHTMLRectCollection getClientRects();

        [DispId(-2147417067)]
        IHTMLRect getBoundingClientRect();

        [DispId(-2147417608)]
        void setExpression([MarshalAs(UnmanagedType.BStr)] string propname, [MarshalAs(UnmanagedType.BStr)] string expression, [MarshalAs(UnmanagedType.BStr)] string language);

        [DispId(-2147417607)]
        object getExpression([MarshalAs(UnmanagedType.BStr)] string propname);

        [DispId(-2147417606)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeExpression([MarshalAs(UnmanagedType.BStr)] string propname);

        [DispId(-2147416112)]
        void focus();

        [DispId(-2147416110)]
        void blur();

        [DispId(-2147416095)]
        void addFilter([MarshalAs(UnmanagedType.IUnknown)] object pUnk);

        [DispId(-2147416094)]
        void removeFilter([MarshalAs(UnmanagedType.IUnknown)] object pUnk);

        [DispId(-2147417605)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool attachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(-2147417604)]
        void detachEvent([MarshalAs(UnmanagedType.BStr)] string eventName, [MarshalAs(UnmanagedType.IDispatch)] object pdisp);

        [DispId(-2147417056)]
        [return: MarshalAs(UnmanagedType.IDispatch)]
        object createControlRange();

        [DispId(-2147417050)]
        void clearAttributes();

        [DispId(-2147417043)]
        IHTMLElement insertAdjacentElement([MarshalAs(UnmanagedType.BStr)] string where, IHTMLElement insertedElement);

        [DispId(-2147417047)]
        IHTMLElement applyElement(IHTMLElement apply, [MarshalAs(UnmanagedType.BStr)] string where);

        [DispId(-2147417042)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getAdjacentText([MarshalAs(UnmanagedType.BStr)] string where);

        [DispId(-2147417041)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string replaceAdjacentText([MarshalAs(UnmanagedType.BStr)] string where, [MarshalAs(UnmanagedType.BStr)] string newText);

        [DispId(-2147417032)]
        int addBehavior([MarshalAs(UnmanagedType.BStr)] string bstrUrl, [In] ref object pvarFactory);

        [DispId(-2147417031)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool removeBehavior(int cookie);

        [DispId(-2147417027)]
        IHTMLElementCollection getElementsByTagName([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(-2147417016)]
        void mergeAttributes(IHTMLElement mergeThis, [In] ref object pvarFlags);

        [DispId(-2147417011)]
        void setActive();

        [DispId(-2147417006)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool FireEvent([MarshalAs(UnmanagedType.BStr)] string bstrEventName, [In] ref object pvarEventObject);

        [DispId(-2147417005)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool dragDrop();

        [DispId(-2147417000)]
        void normalize();

        [DispId(-2147417003)]
        IHTMLDOMAttribute getAttributeNode([MarshalAs(UnmanagedType.BStr)] string bstrName);

        [DispId(-2147417002)]
        IHTMLDOMAttribute setAttributeNode(IHTMLDOMAttribute pattr);

        [DispId(-2147417001)]
        IHTMLDOMAttribute removeAttributeNode(IHTMLDOMAttribute pattr);

        [DispId(-2147417064)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasChildNodes();

        [DispId(-2147417061)]
        IHTMLDOMNode insertBefore(IHTMLDOMNode newChild, object refChild);

        [DispId(-2147417060)]
        IHTMLDOMNode removeChild(IHTMLDOMNode oldChild);

        [DispId(-2147417059)]
        IHTMLDOMNode replaceChild(IHTMLDOMNode newChild, IHTMLDOMNode oldChild);

        [DispId(-2147417051)]
        IHTMLDOMNode cloneNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417046)]
        IHTMLDOMNode removeNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        [DispId(-2147417044)]
        IHTMLDOMNode swapNode(IHTMLDOMNode otherNode);

        [DispId(-2147417045)]
        IHTMLDOMNode replaceNode(IHTMLDOMNode replacement);

        [DispId(-2147417039)]
        IHTMLDOMNode appendChild(IHTMLDOMNode newChild);

        [DispId(-2147416912)]
        IHTMLDOMAttribute2 ie8_getAttributeNode([MarshalAs(UnmanagedType.BStr)] string bstrName);

        [DispId(-2147416911)]
        IHTMLDOMAttribute2 ie8_setAttributeNode(IHTMLDOMAttribute2 pattr);

        [DispId(-2147416910)]
        IHTMLDOMAttribute2 ie8_removeAttributeNode(IHTMLDOMAttribute2 pattr);

        [DispId(-2147416909)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasAttribute([MarshalAs(UnmanagedType.BStr)] string name);

        [DispId(-2147416894)]
        object ie8_getAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName);

        [DispId(-2147416893)]
        void ie8_setAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName, object AttributeValue);

        [DispId(-2147416892)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool ie8_removeAttribute([MarshalAs(UnmanagedType.BStr)] string strAttributeName);

        [DispId(-2147416878)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasAttributes();

        [DispId(-2147416998)]
        IHTMLElement querySelector([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(-2147416997)]
        IHTMLDOMChildrenCollection querySelectorAll([MarshalAs(UnmanagedType.BStr)] string v);

        [DispId(2004)]
        void select();

        [DispId(2006)]
        IHTMLTxtRange createTextRange();

        string accept
        {
            [DispId(2022)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2022)]
            set;
        }

        string accessKey
        {
            [DispId(-2147416107)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416107)]
            set;
        }

        string align
        {
            [DispId(-2147418039)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418039)]
            set;
        }

        object all
        {
            [DispId(-2147417074)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string alt
        {
            [DispId(2010)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2010)]
            set;
        }

        string ariaActivedescendant
        {
            [DispId(-2147416880)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416880)]
            set;
        }

        string ariaBusy
        {
            [DispId(-2147416907)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416907)]
            set;
        }

        string ariaChecked
        {
            [DispId(-2147416906)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416906)]
            set;
        }

        string ariaControls
        {
            [DispId(-2147416884)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416884)]
            set;
        }

        string ariaDescribedby
        {
            [DispId(-2147416883)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416883)]
            set;
        }

        string ariaDisabled
        {
            [DispId(-2147416905)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416905)]
            set;
        }

        string ariaExpanded
        {
            [DispId(-2147416904)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416904)]
            set;
        }

        string ariaFlowto
        {
            [DispId(-2147416882)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416882)]
            set;
        }

        string ariaHaspopup
        {
            [DispId(-2147416903)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416903)]
            set;
        }

        string ariaHidden
        {
            [DispId(-2147416902)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416902)]
            set;
        }

        string ariaInvalid
        {
            [DispId(-2147416901)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416901)]
            set;
        }

        string ariaLabelledby
        {
            [DispId(-2147416881)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416881)]
            set;
        }

        short ariaLevel
        {
            [DispId(-2147416887)]
            get;
            [DispId(-2147416887)]
            set;
        }

        string ariaLive
        {
            [DispId(-2147416877)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416877)]
            set;
        }

        string ariaMultiselectable
        {
            [DispId(-2147416900)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416900)]
            set;
        }

        string ariaOwns
        {
            [DispId(-2147416879)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416879)]
            set;
        }

        short ariaPosinset
        {
            [DispId(-2147416889)]
            get;
            [DispId(-2147416889)]
            set;
        }

        string ariaPressed
        {
            [DispId(-2147416899)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416899)]
            set;
        }

        string ariaReadonly
        {
            [DispId(-2147416898)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416898)]
            set;
        }

        string ariaRelevant
        {
            [DispId(-2147416876)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416876)]
            set;
        }

        string ariaRequired
        {
            [DispId(-2147416897)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416897)]
            set;
        }

        string ariaSecret
        {
            [DispId(-2147416896)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416896)]
            set;
        }

        string ariaSelected
        {
            [DispId(-2147416895)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416895)]
            set;
        }

        short ariaSetsize
        {
            [DispId(-2147416888)]
            get;
            [DispId(-2147416888)]
            set;
        }

        string ariaValuemax
        {
            [DispId(-2147416885)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416885)]
            set;
        }

        string ariaValuemin
        {
            [DispId(-2147416886)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416886)]
            set;
        }

        string ariaValuenow
        {
            [DispId(-2147416890)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416890)]
            set;
        }

        object attributes
        {
            [DispId(-2147417062)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        object behaviorUrns
        {
            [DispId(-2147417030)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        object border
        {
            [DispId(2012)]
            get;
            [DispId(2012)]
            set;
        }

        bool canHaveChildren
        {
            [DispId(-2147417040)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        bool canHaveHTML
        {
            [DispId(-2147417014)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        bool checkedx
        {
            [DispId(2009)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2009)]
            set;
        }

        object childNodes
        {
            [DispId(-2147417063)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        object children
        {
            [DispId(-2147417075)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string className
        {
            [DispId(-2147417111)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417111)]
            set;
        }

        int clientHeight
        {
            [DispId(-2147416093)]
            get;
        }

        int clientLeft
        {
            [DispId(-2147416090)]
            get;
        }

        int clientTop
        {
            [DispId(-2147416091)]
            get;
        }

        int clientWidth
        {
            [DispId(-2147416092)]
            get;
        }

        bool complete
        {
            [DispId(2018)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        object constructor
        {
            [DispId(-2147417603)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string contentEditable
        {
            [DispId(-2147412950)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412950)]
            set;
        }

        IHTMLCurrentStyle currentStyle
        {
            [DispId(-2147417105)]
            get;
        }

        string dataFld
        {
            [DispId(-2147417091)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417091)]
            set;
        }

        string dataFormatAs
        {
            [DispId(-2147417089)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417089)]
            set;
        }

        string dataSrc
        {
            [DispId(-2147417090)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417090)]
            set;
        }

        bool defaultChecked
        {
            [DispId(2008)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2008)]
            set;
        }

        string defaultValue
        {
            [DispId(-2147413029)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413029)]
            set;
        }

        string dir
        {
            [DispId(-2147412995)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147412995)]
            set;
        }

        bool disabled
        {
            [DispId(-2147418036)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147418036)]
            set;
        }

        object document
        {
            [DispId(-2147417094)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        string dynsrc
        {
            [DispId(2017)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2017)]
            set;
        }

        IHTMLFiltersCollection filters
        {
            [DispId(-2147417077)]
            get;
        }

        IHTMLDOMNode firstChild
        {
            [DispId(-2147417036)]
            get;
        }

        IHTMLFormElement form
        {
            [DispId(-2147416108)]
            get;
        }

        int glyphMode
        {
            [DispId(-2147417004)]
            get;
        }

        int height
        {
            [DispId(-2147418106)]
            get;
            [DispId(-2147418106)]
            set;
        }

        bool hideFocus
        {
            [DispId(-2147412949)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147412949)]
            set;
        }

        int hspace
        {
            [DispId(2014)]
            get;
            [DispId(2014)]
            set;
        }

        string id
        {
            [DispId(-2147417110)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417110)]
            set;
        }

        IHTMLAttributeCollection3 ie8_attributes
        {
            [DispId(-2147416891)]
            get;
        }

        string ie8_dynsrc
        {
            [DispId(1153)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1153)]
            set;
        }

        string ie8_lowsrc
        {
            [DispId(1151)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1151)]
            set;
        }

        string ie8_src
        {
            [DispId(1150)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1150)]
            set;
        }

        string ie8_vrml
        {
            [DispId(1152)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1152)]
            set;
        }

        bool indeterminate
        {
            [DispId(2007)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2007)]
            set;
        }

        bool inflateBlock
        {
            [DispId(-2147417012)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(-2147417012)]
            set;
        }

        string innerHTML
        {
            [DispId(-2147417086)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417086)]
            set;
        }

        string innerText
        {
            [DispId(-2147417085)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417085)]
            set;
        }

        bool isContentEditable
        {
            [DispId(-2147417010)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        bool isDisabled
        {
            [DispId(-2147417007)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        bool isMultiLine
        {
            [DispId(-2147417015)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        bool isTextEdit
        {
            [DispId(-2147417078)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        string lang
        {
            [DispId(-2147413103)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413103)]
            set;
        }

        string language
        {
            [DispId(-2147413012)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413012)]
            set;
        }

        IHTMLDOMNode lastChild
        {
            [DispId(-2147417035)]
            get;
        }

        object loop
        {
            [DispId(2019)]
            get;
            [DispId(2019)]
            set;
        }

        string lowsrc
        {
            [DispId(2015)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2015)]
            set;
        }

        int maxLength
        {
            [DispId(2003)]
            get;
            [DispId(2003)]
            set;
        }

        string name
        {
            [DispId(-2147418112)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418112)]
            set;
        }

        IHTMLDOMNode nextSibling
        {
            [DispId(-2147417033)]
            get;
        }

        string nodeName
        {
            [DispId(-2147417038)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int nodeType
        {
            [DispId(-2147417066)]
            get;
        }

        object nodeValue
        {
            [DispId(-2147417037)]
            get;
            [DispId(-2147417037)]
            set;
        }

        int offsetHeight
        {
            [DispId(-2147417101)]
            get;
        }

        int offsetLeft
        {
            [DispId(-2147417104)]
            get;
        }

        IHTMLElement offsetParent
        {
            [DispId(-2147417100)]
            get;
        }

        int offsetTop
        {
            [DispId(-2147417103)]
            get;
        }

        int offsetWidth
        {
            [DispId(-2147417102)]
            get;
        }

        object onabort
        {
            [DispId(-2147412084)]
            get;
            [DispId(-2147412084)]
            set;
        }

        object onactivate
        {
            [DispId(-2147412025)]
            get;
            [DispId(-2147412025)]
            set;
        }

        object onafterupdate
        {
            [DispId(-2147412090)]
            get;
            [DispId(-2147412090)]
            set;
        }

        object onbeforeactivate
        {
            [DispId(-2147412022)]
            get;
            [DispId(-2147412022)]
            set;
        }

        object onbeforecopy
        {
            [DispId(-2147412053)]
            get;
            [DispId(-2147412053)]
            set;
        }

        object onbeforecut
        {
            [DispId(-2147412054)]
            get;
            [DispId(-2147412054)]
            set;
        }

        object onbeforedeactivate
        {
            [DispId(-2147412035)]
            get;
            [DispId(-2147412035)]
            set;
        }

        object onbeforeeditfocus
        {
            [DispId(-2147412043)]
            get;
            [DispId(-2147412043)]
            set;
        }

        object onbeforepaste
        {
            [DispId(-2147412052)]
            get;
            [DispId(-2147412052)]
            set;
        }

        object onbeforeupdate
        {
            [DispId(-2147412091)]
            get;
            [DispId(-2147412091)]
            set;
        }

        object onblur
        {
            [DispId(-2147412097)]
            get;
            [DispId(-2147412097)]
            set;
        }

        object oncellchange
        {
            [DispId(-2147412048)]
            get;
            [DispId(-2147412048)]
            set;
        }

        object onchange
        {
            [DispId(-2147412082)]
            get;
            [DispId(-2147412082)]
            set;
        }

        object onclick
        {
            [DispId(-2147412104)]
            get;
            [DispId(-2147412104)]
            set;
        }

        object oncontextmenu
        {
            [DispId(-2147412047)]
            get;
            [DispId(-2147412047)]
            set;
        }

        object oncontrolselect
        {
            [DispId(-2147412033)]
            get;
            [DispId(-2147412033)]
            set;
        }

        object oncopy
        {
            [DispId(-2147412056)]
            get;
            [DispId(-2147412056)]
            set;
        }

        object oncut
        {
            [DispId(-2147412057)]
            get;
            [DispId(-2147412057)]
            set;
        }

        object ondataavailable
        {
            [DispId(-2147412071)]
            get;
            [DispId(-2147412071)]
            set;
        }

        object ondatasetchanged
        {
            [DispId(-2147412072)]
            get;
            [DispId(-2147412072)]
            set;
        }

        object ondatasetcomplete
        {
            [DispId(-2147412070)]
            get;
            [DispId(-2147412070)]
            set;
        }

        object ondblclick
        {
            [DispId(-2147412103)]
            get;
            [DispId(-2147412103)]
            set;
        }

        object ondeactivate
        {
            [DispId(-2147412024)]
            get;
            [DispId(-2147412024)]
            set;
        }

        object ondrag
        {
            [DispId(-2147412063)]
            get;
            [DispId(-2147412063)]
            set;
        }

        object ondragend
        {
            [DispId(-2147412062)]
            get;
            [DispId(-2147412062)]
            set;
        }

        object ondragenter
        {
            [DispId(-2147412061)]
            get;
            [DispId(-2147412061)]
            set;
        }

        object ondragleave
        {
            [DispId(-2147412059)]
            get;
            [DispId(-2147412059)]
            set;
        }

        object ondragover
        {
            [DispId(-2147412060)]
            get;
            [DispId(-2147412060)]
            set;
        }

        object ondragstart
        {
            [DispId(-2147412077)]
            get;
            [DispId(-2147412077)]
            set;
        }

        object ondrop
        {
            [DispId(-2147412058)]
            get;
            [DispId(-2147412058)]
            set;
        }

        object onerror
        {
            [DispId(-2147412083)]
            get;
            [DispId(-2147412083)]
            set;
        }

        object onerrorupdate
        {
            [DispId(-2147412074)]
            get;
            [DispId(-2147412074)]
            set;
        }

        object onfilterchange
        {
            [DispId(-2147412069)]
            get;
            [DispId(-2147412069)]
            set;
        }

        object onfocus
        {
            [DispId(-2147412098)]
            get;
            [DispId(-2147412098)]
            set;
        }

        object onfocusin
        {
            [DispId(-2147412021)]
            get;
            [DispId(-2147412021)]
            set;
        }

        object onfocusout
        {
            [DispId(-2147412020)]
            get;
            [DispId(-2147412020)]
            set;
        }

        object onhelp
        {
            [DispId(-2147412099)]
            get;
            [DispId(-2147412099)]
            set;
        }

        object onkeydown
        {
            [DispId(-2147412107)]
            get;
            [DispId(-2147412107)]
            set;
        }

        object onkeypress
        {
            [DispId(-2147412105)]
            get;
            [DispId(-2147412105)]
            set;
        }

        object onkeyup
        {
            [DispId(-2147412106)]
            get;
            [DispId(-2147412106)]
            set;
        }

        object onlayoutcomplete
        {
            [DispId(-2147412039)]
            get;
            [DispId(-2147412039)]
            set;
        }

        object onload
        {
            [DispId(-2147412080)]
            get;
            [DispId(-2147412080)]
            set;
        }

        object onlosecapture
        {
            [DispId(-2147412066)]
            get;
            [DispId(-2147412066)]
            set;
        }

        object onmousedown
        {
            [DispId(-2147412110)]
            get;
            [DispId(-2147412110)]
            set;
        }

        object onmouseenter
        {
            [DispId(-2147412027)]
            get;
            [DispId(-2147412027)]
            set;
        }

        object onmouseleave
        {
            [DispId(-2147412026)]
            get;
            [DispId(-2147412026)]
            set;
        }

        object onmousemove
        {
            [DispId(-2147412108)]
            get;
            [DispId(-2147412108)]
            set;
        }

        object onmouseout
        {
            [DispId(-2147412111)]
            get;
            [DispId(-2147412111)]
            set;
        }

        object onmouseover
        {
            [DispId(-2147412112)]
            get;
            [DispId(-2147412112)]
            set;
        }

        object onmouseup
        {
            [DispId(-2147412109)]
            get;
            [DispId(-2147412109)]
            set;
        }

        object onmousewheel
        {
            [DispId(-2147412036)]
            get;
            [DispId(-2147412036)]
            set;
        }

        object onmove
        {
            [DispId(-2147412034)]
            get;
            [DispId(-2147412034)]
            set;
        }

        object onmoveend
        {
            [DispId(-2147412030)]
            get;
            [DispId(-2147412030)]
            set;
        }

        object onmovestart
        {
            [DispId(-2147412031)]
            get;
            [DispId(-2147412031)]
            set;
        }

        object onpage
        {
            [DispId(-2147412038)]
            get;
            [DispId(-2147412038)]
            set;
        }

        object onpaste
        {
            [DispId(-2147412055)]
            get;
            [DispId(-2147412055)]
            set;
        }

        object onpropertychange
        {
            [DispId(-2147412065)]
            get;
            [DispId(-2147412065)]
            set;
        }

        object onreadystatechange
        {
            [DispId(-2147412087)]
            get;
            [DispId(-2147412087)]
            set;
        }

        object onresize
        {
            [DispId(-2147412076)]
            get;
            [DispId(-2147412076)]
            set;
        }

        object onresizeend
        {
            [DispId(-2147412028)]
            get;
            [DispId(-2147412028)]
            set;
        }

        object onresizestart
        {
            [DispId(-2147412029)]
            get;
            [DispId(-2147412029)]
            set;
        }

        object onrowenter
        {
            [DispId(-2147412093)]
            get;
            [DispId(-2147412093)]
            set;
        }

        object onrowexit
        {
            [DispId(-2147412094)]
            get;
            [DispId(-2147412094)]
            set;
        }

        object onrowsdelete
        {
            [DispId(-2147412050)]
            get;
            [DispId(-2147412050)]
            set;
        }

        object onrowsinserted
        {
            [DispId(-2147412049)]
            get;
            [DispId(-2147412049)]
            set;
        }

        object onscroll
        {
            [DispId(-2147412081)]
            get;
            [DispId(-2147412081)]
            set;
        }

        object onselect
        {
            [DispId(-2147412102)]
            get;
            [DispId(-2147412102)]
            set;
        }

        object onselectstart
        {
            [DispId(-2147412075)]
            get;
            [DispId(-2147412075)]
            set;
        }

        string outerHTML
        {
            [DispId(-2147417084)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417084)]
            set;
        }

        string outerText
        {
            [DispId(-2147417083)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417083)]
            set;
        }

        object ownerDocument
        {
            [DispId(-2147416999)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLElement parentElement
        {
            [DispId(-2147418104)]
            get;
        }

        IHTMLDOMNode parentNode
        {
            [DispId(-2147417065)]
            get;
        }

        IHTMLElement parentTextEdit
        {
            [DispId(-2147417080)]
            get;
        }

        IHTMLDOMNode previousSibling
        {
            [DispId(-2147417034)]
            get;
        }

        bool readOnly
        {
            [DispId(2005)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2005)]
            set;
        }

        object readyState
        {
            [DispId(-2147412996)]
            get;
        }

        int readyStateValue
        {
            [DispId(-2147417028)]
            get;
        }

        object recordNumber
        {
            [DispId(-2147417087)]
            get;
        }

        string role
        {
            [DispId(-2147416908)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147416908)]
            set;
        }

        IHTMLStyle runtimeStyle
        {
            [DispId(-2147417048)]
            get;
        }

        string scopeName
        {
            [DispId(-2147417073)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int scrollHeight
        {
            [DispId(-2147417055)]
            get;
        }

        int scrollLeft
        {
            [DispId(-2147417052)]
            get;
            [DispId(-2147417052)]
            set;
        }

        int scrollTop
        {
            [DispId(-2147417053)]
            get;
            [DispId(-2147417053)]
            set;
        }

        int scrollWidth
        {
            [DispId(-2147417054)]
            get;
        }

        int size
        {
            [DispId(2002)]
            get;
            [DispId(2002)]
            set;
        }

        int sourceIndex
        {
            [DispId(-2147417088)]
            get;
        }

        string src
        {
            [DispId(2011)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2011)]
            set;
        }

        string Start
        {
            [DispId(2020)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2020)]
            set;
        }

        bool status
        {
            [DispId(2001)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
            [DispId(2001)]
            set;
        }

        IHTMLStyle style
        {
            [DispId(-2147418038)]
            get;
        }

        short tabIndex
        {
            [DispId(-2147418097)]
            get;
            [DispId(-2147418097)]
            set;
        }

        string tagName
        {
            [DispId(-2147417108)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string tagUrn
        {
            [DispId(-2147417029)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147417029)]
            set;
        }

        string title
        {
            [DispId(-2147418043)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147418043)]
            set;
        }

        string type
        {
            [DispId(2000)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2000)]
            set;
        }

        string uniqueID
        {
            [DispId(-2147417057)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        int uniqueNumber
        {
            [DispId(-2147417058)]
            get;
        }

        string useMap
        {
            [DispId(2023)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2023)]
            set;
        }

        string value
        {
            [DispId(-2147413011)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(-2147413011)]
            set;
        }

        string vrml
        {
            [DispId(2016)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(2016)]
            set;
        }

        int vspace
        {
            [DispId(2013)]
            get;
            [DispId(2013)]
            set;
        }

        int width
        {
            [DispId(-2147418107)]
            get;
            [DispId(-2147418107)]
            set;
        }
    }


    [Guid("30510469-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLAttributeCollection3
    {
        [DispId(1150)]
        IHTMLDOMAttribute getNamedItem([MarshalAs(UnmanagedType.BStr)] string bstrName);

        [DispId(1151)]
        IHTMLDOMAttribute setNamedItem(IHTMLDOMAttribute pNodeIn);

        [DispId(1152)]
        IHTMLDOMAttribute removeNamedItem([MarshalAs(UnmanagedType.BStr)] string bstrName);

        [DispId(1154)]
        IHTMLDOMAttribute item(int index);

        int length
        {
            [DispId(1153)]
            get;
        }
    }



    [Guid("3050F810-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLDOMAttribute2
    {
        [DispId(1015)]
        IHTMLDOMNode insertBefore(IHTMLDOMNode newChild, object refChild);

        [DispId(1016)]
        IHTMLDOMNode replaceChild(IHTMLDOMNode newChild, IHTMLDOMNode oldChild);

        [DispId(1017)]
        IHTMLDOMNode removeChild(IHTMLDOMNode oldChild);

        [DispId(1018)]
        IHTMLDOMNode appendChild(IHTMLDOMNode newChild);

        [DispId(1019)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool hasChildNodes();

        [DispId(1020)]
        IHTMLDOMAttribute cloneNode([MarshalAs(UnmanagedType.VariantBool)] bool fDeep);

        object attributes
        {
            [DispId(1013)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        object childNodes
        {
            [DispId(1008)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        bool expando
        {
            [DispId(1005)]
            [return: MarshalAs(UnmanagedType.VariantBool)]
            get;
        }

        IHTMLDOMNode firstChild
        {
            [DispId(1009)]
            get;
        }

        IHTMLDOMNode lastChild
        {
            [DispId(1010)]
            get;
        }

        string name
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        IHTMLDOMNode nextSibling
        {
            [DispId(1012)]
            get;
        }

        int nodeType
        {
            [DispId(1006)]
            get;
        }

        object ownerDocument
        {
            [DispId(1014)]
            [return: MarshalAs(UnmanagedType.IDispatch)]
            get;
        }

        IHTMLDOMNode parentNode
        {
            [DispId(1007)]
            get;
        }

        IHTMLDOMNode previousSibling
        {
            [DispId(1011)]
            get;
        }

        string value
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1004)]
            set;
        }
    }



    [Guid("3050F220-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLTxtRange
    {
        [DispId(1006)]
        IHTMLElement parentElement();

        [DispId(1008)]
        IHTMLTxtRange duplicate();

        [DispId(1010)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool inRange(IHTMLTxtRange range);

        [DispId(1011)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool isEqual(IHTMLTxtRange range);

        [DispId(1012)]
        void scrollIntoView([MarshalAs(UnmanagedType.VariantBool)] bool fStart);

        [DispId(1013)]
        void collapse([MarshalAs(UnmanagedType.VariantBool)] bool Start);

        [DispId(1014)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool expand([MarshalAs(UnmanagedType.BStr)] string Unit);

        [DispId(1015)]
        int move([MarshalAs(UnmanagedType.BStr)] string Unit, int Count);

        [DispId(1016)]
        int moveStart([MarshalAs(UnmanagedType.BStr)] string Unit, int Count);

        [DispId(1017)]
        int moveEnd([MarshalAs(UnmanagedType.BStr)] string Unit, int Count);

        [DispId(1024)]
        void select();

        [DispId(1026)]
        void pasteHTML([MarshalAs(UnmanagedType.BStr)] string html);

        [DispId(1001)]
        void moveToElementText(IHTMLElement element);

        [DispId(1025)]
        void setEndPoint([MarshalAs(UnmanagedType.BStr)] string how, IHTMLTxtRange SourceRange);

        [DispId(1018)]
        int compareEndPoints([MarshalAs(UnmanagedType.BStr)] string how, IHTMLTxtRange SourceRange);

        [DispId(1019)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool findText([MarshalAs(UnmanagedType.BStr)] string String, int Count, int Flags);

        [DispId(1020)]
        void moveToPoint(int x, int y);

        [DispId(1021)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string getBookmark();

        [DispId(1009)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool moveToBookmark([MarshalAs(UnmanagedType.BStr)] string Bookmark);

        [DispId(1027)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandSupported([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1028)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandEnabled([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1029)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandState([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1030)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool queryCommandIndeterm([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1031)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string queryCommandText([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1032)]
        object queryCommandValue([MarshalAs(UnmanagedType.BStr)] string cmdID);

        [DispId(1033)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommand([MarshalAs(UnmanagedType.BStr)] string cmdID, [MarshalAs(UnmanagedType.VariantBool)] bool showUI, object value);

        [DispId(1034)]
        [return: MarshalAs(UnmanagedType.VariantBool)]
        bool execCommandShowHelp([MarshalAs(UnmanagedType.BStr)] string cmdID);

        string htmlText
        {
            [DispId(1003)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string text
        {
            [DispId(1004)]
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [DispId(1004)]
            set;
        }
    }


    [Guid("3050F3EE-98B5-11CF-BB82-00AA00BDCE0B")]
    [ComImport]
    [TypeLibType((short)4160)]
    [DefaultMember("item")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IHTMLFiltersCollection : System.Collections.IEnumerable
    {
        [DispId(0)]
        object item([In] ref object pvarIndex);

        object _newEnum
        {
            [DispId(-4)]
            [return: MarshalAs(UnmanagedType.IUnknown)]
            get;
        }

        int length
        {
            [DispId(1001)]
            get;
        }
    }
}
