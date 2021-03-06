﻿/************************************************************************************************************
 * This software is distributed under a GNU Lesser License by Elastacloud Limited and it is free to         *
 * modify and distribute providing the terms of the license are followed. From the root of the source the   *
 * license can be found in /Resources/license.txt                                                           * 
 *                                                                                                          *
 * Web at: www.elastacloud.com                                                                              *
 * Email: info@elastacloud.com                                                                              *
 ************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Elastacloud.AzureManagement.Fluent.Commands.Parsers;
using Elastacloud.AzureManagement.Fluent.Commands.Services;
using Elastacloud.AzureManagement.Fluent.Helpers;
using Elastacloud.AzureManagement.Fluent.Types.Websites;

namespace Elastacloud.AzureManagement.Fluent.Commands.Websites
{
    /// <summary>
    /// Used to create a hosted service within a given subscription
    /// </summary>
    internal class DeleteWebsiteCommand : ServiceCommand
    {
        /// <summary>
        /// Constructs a websites list command
        /// </summary>
        internal DeleteWebsiteCommand(string region, string sitename)
        {
            HttpVerb = HttpVerbDelete;
            ServiceType = "services";
            OperationId = "webspaces";
            // keep this in to ensure no 403
            HttpCommand = String.Format("{0}/sites/{1}", region, sitename);
            /* propertiesToInclude=repositoryuri%2Cpublishingpassword%2Cpublishingusername */
        }
    }
}