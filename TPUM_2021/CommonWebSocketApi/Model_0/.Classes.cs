/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace 
{
    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CustomerS ObjectType.
        /// </summary>
        public const uint CustomerS = 3;

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public const uint InvoiceS = 7;

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public const uint ProductS = 13;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the CustomerS_Id Variable.
        /// </summary>
        public const uint CustomerS_Id = 4;

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public const uint CustomerS_Name = 5;

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public const uint CustomerS_Funds = 6;

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public const uint InvoiceS_Id = 8;

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public const uint InvoiceS_ProductId = 9;

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public const uint InvoiceS_CustomerId = 10;

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public const uint InvoiceS_Date = 11;

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public const uint InvoiceS_Price = 12;

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public const uint ProductS_Id = 14;

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public const uint ProductS_Name = 15;

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public const uint ProductS_Price = 16;

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public const uint ProductS_CustomerId = 17;
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the CustomerS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS = new ExpandedNodeId(.ObjectTypes.CustomerS, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS = new ExpandedNodeId(.ObjectTypes.InvoiceS, .Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProductS = new ExpandedNodeId(Opc.Ua.ObjectTypes.ProductS, Opc.Ua.Namespaces.OpcUa);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the CustomerS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Id = new ExpandedNodeId(.Variables.CustomerS_Id, .Namespaces.cas);

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Name = new ExpandedNodeId(.Variables.CustomerS_Name, .Namespaces.cas);

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Funds = new ExpandedNodeId(.Variables.CustomerS_Funds, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Id = new ExpandedNodeId(.Variables.InvoiceS_Id, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_ProductId = new ExpandedNodeId(.Variables.InvoiceS_ProductId, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_CustomerId = new ExpandedNodeId(.Variables.InvoiceS_CustomerId, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Date = new ExpandedNodeId(.Variables.InvoiceS_Date, .Namespaces.cas);

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Price = new ExpandedNodeId(.Variables.InvoiceS_Price, .Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Id = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Id, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Name = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Name, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Price = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Price, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_CustomerId = new ExpandedNodeId(Opc.Ua.Variables.ProductS_CustomerId, Opc.Ua.Namespaces.OpcUa);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CustomerS component.
        /// </summary>
        public const string CustomerS = "CustomerS";

        /// <summary>
        /// The BrowseName for the InvoiceS component.
        /// </summary>
        public const string InvoiceS = "InvoiceS";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cas namespace (.NET code namespace is '').
        /// </summary>
        public const string cas = "http://cas.eu/UA/CommServer/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion

    #region CustomerSState Class
    #if (!OPCUA_EXCLUDE_CustomerSState)
    /// <summary>
    /// Stores an instance of the CustomerS ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CustomerSState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CustomerSState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(.ObjectTypes.CustomerS, .Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAABAAAAAQARAAAAQ3VzdG9t" +
           "ZXJTSW5zdGFuY2UBAQMAAQEDAP////8DAAAAFWCJCgIAAAAAAAIAAABJZAEBBAAALwA/BAAAAAAG////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAE5hbWUBAQUAAC8APwUAAAAADP////8DA/////8AAAAAFWCJ" +
           "CgIAAAAAAAUAAABGdW5kcwEBBgAALwA/BgAAAAAy/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Id Variable.
        /// </summary>
        public BaseDataVariableState<int> Id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <summary>
        /// A description for the Name Variable.
        /// </summary>
        public BaseDataVariableState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <summary>
        /// A description for the Funds Variable.
        /// </summary>
        public BaseDataVariableState Funds
        {
            get
            {
                return m_funds;
            }

            set
            {
                if (!Object.ReferenceEquals(m_funds, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_funds = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_funds != null)
            {
                children.Add(m_funds);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case Opc.Ua.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Name = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Opc.Ua.BrowseNames.Funds:
                {
                    if (createOrReplace)
                    {
                        if (Funds == null)
                        {
                            if (replacement == null)
                            {
                                Funds = new BaseDataVariableState(this);
                            }
                            else
                            {
                                Funds = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = Funds;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<string> m_name;
        private BaseDataVariableState m_funds;
        #endregion
    }
    #endif
    #endregion

    #region InvoiceSState Class
    #if (!OPCUA_EXCLUDE_InvoiceSState)
    /// <summary>
    /// Stores an instance of the InvoiceS ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InvoiceSState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InvoiceSState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(.ObjectTypes.InvoiceS, .Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAABAAAAAQAQAAAASW52b2lj" +
           "ZVNJbnN0YW5jZQEBBwABAQcA/////wUAAAAVYIkKAgAAAAAAAgAAAElkAQEIAAAvAD8IAAAAAAb/////" +
           "AwP/////AAAAABVgiQoCAAAAAAAJAAAAUHJvZHVjdElkAQEJAAAvAD8JAAAAAAb/////AwP/////AAAA" +
           "ABVgiQoCAAAAAAAKAAAAQ3VzdG9tZXJJZAEBCgAALwA/CgAAAAAG/////wMD/////wAAAAAVYIkKAgAA" +
           "AAAABAAAAERhdGUBAQsAAC8APwsAAAAADf////8DA/////8AAAAAFWCJCgIAAAAAAAUAAABQcmljZQEB" +
           "DAAALwA/DAAAAAAy/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Id Variable.
        /// </summary>
        public BaseDataVariableState<int> Id
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!Object.ReferenceEquals(m_id, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_id = value;
            }
        }

        /// <summary>
        /// A description for the ProductId Variable.
        /// </summary>
        public BaseDataVariableState<int> ProductId
        {
            get
            {
                return m_productId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productId = value;
            }
        }

        /// <summary>
        /// A description for the CustomerId Variable.
        /// </summary>
        public BaseDataVariableState<int> CustomerId
        {
            get
            {
                return m_customerId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_customerId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_customerId = value;
            }
        }

        /// <summary>
        /// A description for the Date Variable.
        /// </summary>
        public BaseDataVariableState<DateTime> Date
        {
            get
            {
                return m_date;
            }

            set
            {
                if (!Object.ReferenceEquals(m_date, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_date = value;
            }
        }

        /// <summary>
        /// A description for the Price Variable.
        /// </summary>
        public BaseDataVariableState Price
        {
            get
            {
                return m_price;
            }

            set
            {
                if (!Object.ReferenceEquals(m_price, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_price = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_id != null)
            {
                children.Add(m_id);
            }

            if (m_productId != null)
            {
                children.Add(m_productId);
            }

            if (m_customerId != null)
            {
                children.Add(m_customerId);
            }

            if (m_date != null)
            {
                children.Add(m_date);
            }

            if (m_price != null)
            {
                children.Add(m_price);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.BrowseNames.Id:
                {
                    if (createOrReplace)
                    {
                        if (Id == null)
                        {
                            if (replacement == null)
                            {
                                Id = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                Id = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = Id;
                    break;
                }

                case Opc.Ua.BrowseNames.ProductId:
                {
                    if (createOrReplace)
                    {
                        if (ProductId == null)
                        {
                            if (replacement == null)
                            {
                                ProductId = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                ProductId = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = ProductId;
                    break;
                }

                case Opc.Ua.BrowseNames.CustomerId:
                {
                    if (createOrReplace)
                    {
                        if (CustomerId == null)
                        {
                            if (replacement == null)
                            {
                                CustomerId = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                CustomerId = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = CustomerId;
                    break;
                }

                case Opc.Ua.BrowseNames.Date:
                {
                    if (createOrReplace)
                    {
                        if (Date == null)
                        {
                            if (replacement == null)
                            {
                                Date = new BaseDataVariableState<DateTime>(this);
                            }
                            else
                            {
                                Date = (BaseDataVariableState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Date;
                    break;
                }

                case Opc.Ua.BrowseNames.Price:
                {
                    if (createOrReplace)
                    {
                        if (Price == null)
                        {
                            if (replacement == null)
                            {
                                Price = new BaseDataVariableState(this);
                            }
                            else
                            {
                                Price = (BaseDataVariableState)replacement;
                            }
                        }
                    }

                    instance = Price;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<int> m_id;
        private BaseDataVariableState<int> m_productId;
        private BaseDataVariableState<int> m_customerId;
        private BaseDataVariableState<DateTime> m_date;
        private BaseDataVariableState m_price;
        #endregion
    }
    #endif
    #endregion
}