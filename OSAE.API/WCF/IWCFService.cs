﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using OSAE;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    public interface IWCFService
    {
        [OperationContract]
        void SendMessageToClients(OSAEWCFMessage message);

        [OperationContract]
        bool Subscribe();

        [OperationContract]
        bool Unsubscribe();

        [OperationContract]
        void messageHost(OSAEWCFMessageType msgType, string message, string from);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObjectCollection GetAllObjects();

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObject GetObject(string name);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObject GetObjectByAddress(string address);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean ExecuteMethod(string name, string method, string param1, string param2);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean AddObject(string name, string description, string type, string address, string container, string enabled);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean UpdateObject(string oldName, string newName, string description, string type, string address, string container, int enabled);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean DeleteObject(string name);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObjectCollection GetObjectsByType(string type);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObjectCollection GetObjectsByBaseType(string type);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObjectCollection GetObjectsByContainer(string container);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        OSAEObjectCollection GetPlugins();

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean SendPattern(string pattern);

        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        //Boolean AddScript(string objName, string objEvent, string script);

        //[OperationContract]
        //[WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        //Boolean UpdateScript(string objName, string objEvent, string script);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        DataSet ExecuteSQL(string sql);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean SetProperty(string objName, string propName, string propValue);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Boolean SetState(string objName, string state);
    }
}
