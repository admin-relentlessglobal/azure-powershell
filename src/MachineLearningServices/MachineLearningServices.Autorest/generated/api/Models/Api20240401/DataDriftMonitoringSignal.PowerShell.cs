// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(DataDriftMonitoringSignalTypeConverter))]
    public partial class DataDriftMonitoringSignal
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignal"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataDriftMonitoringSignal(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FeatureImportanceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSetting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IFeatureImportanceSettings) content.GetValueForProperty("FeatureImportanceSetting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSetting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.FeatureImportanceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Feature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringFeatureFilterBase) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).Feature, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringFeatureFilterBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProductionData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase) content.GetValueForProperty("ProductionData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase) content.GetValueForProperty("ReferenceData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureDataTypeOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureDataTypeOverride = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalFeatureDataTypeOverride) content.GetValueForProperty("FeatureDataTypeOverride",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureDataTypeOverride, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignalFeatureDataTypeOverrideTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).MetricThreshold = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMetricThresholdBase[]) content.GetValueForProperty("MetricThreshold",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).MetricThreshold, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMetricThresholdBase>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMetricThresholdBaseTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotificationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).NotificationType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType[]) content.GetValueForProperty("NotificationType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).NotificationType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType.CreateFrom));
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringSignalBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SignalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).SignalType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringSignalType) content.GetValueForProperty("SignalType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).SignalType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringSignalType.CreateFrom);
            }
            if (content.Contains("FeatureImportanceSettingTargetColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingTargetColumn = (string) content.GetValueForProperty("FeatureImportanceSettingTargetColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingTargetColumn, global::System.Convert.ToString);
            }
            if (content.Contains("FeatureImportanceSettingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingMode = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode?) content.GetValueForProperty("FeatureImportanceSettingMode",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingMode, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode.CreateFrom);
            }
            if (content.Contains("FeatureFilterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureFilterType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringFeatureFilterType) content.GetValueForProperty("FeatureFilterType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureFilterType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringFeatureFilterType.CreateFrom);
            }
            if (content.Contains("ProductionDataColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataColumn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseColumns) content.GetValueForProperty("ProductionDataColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataColumn, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseColumnsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProductionDataContext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataContext = (string) content.GetValueForProperty("ProductionDataContext",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataContext, global::System.Convert.ToString);
            }
            if (content.Contains("ProductionDataInputDataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataInputDataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType) content.GetValueForProperty("ProductionDataInputDataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataInputDataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType.CreateFrom);
            }
            if (content.Contains("ProductionDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("ProductionDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            if (content.Contains("ProductionDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataUri = (string) content.GetValueForProperty("ProductionDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataUri, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceDataColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataColumn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseColumns) content.GetValueForProperty("ReferenceDataColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataColumn, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseColumnsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceDataContext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataContext = (string) content.GetValueForProperty("ReferenceDataContext",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataContext, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceDataInputDataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataInputDataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType) content.GetValueForProperty("ReferenceDataInputDataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataInputDataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType.CreateFrom);
            }
            if (content.Contains("ReferenceDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("ReferenceDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            if (content.Contains("ReferenceDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataUri = (string) content.GetValueForProperty("ReferenceDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataUri, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignal"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataDriftMonitoringSignal(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FeatureImportanceSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSetting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IFeatureImportanceSettings) content.GetValueForProperty("FeatureImportanceSetting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSetting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.FeatureImportanceSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Feature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringFeatureFilterBase) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).Feature, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringFeatureFilterBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProductionData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase) content.GetValueForProperty("ProductionData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceData = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBase) content.GetValueForProperty("ReferenceData",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceData, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseTypeConverter.ConvertFrom);
            }
            if (content.Contains("FeatureDataTypeOverride"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureDataTypeOverride = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalFeatureDataTypeOverride) content.GetValueForProperty("FeatureDataTypeOverride",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureDataTypeOverride, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignalFeatureDataTypeOverrideTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricThreshold"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).MetricThreshold = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMetricThresholdBase[]) content.GetValueForProperty("MetricThreshold",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).MetricThreshold, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMetricThresholdBase>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMetricThresholdBaseTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotificationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).NotificationType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType[]) content.GetValueForProperty("NotificationType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).NotificationType, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringNotificationType.CreateFrom));
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringSignalBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SignalType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).SignalType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringSignalType) content.GetValueForProperty("SignalType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringSignalBaseInternal)this).SignalType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringSignalType.CreateFrom);
            }
            if (content.Contains("FeatureImportanceSettingTargetColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingTargetColumn = (string) content.GetValueForProperty("FeatureImportanceSettingTargetColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingTargetColumn, global::System.Convert.ToString);
            }
            if (content.Contains("FeatureImportanceSettingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingMode = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode?) content.GetValueForProperty("FeatureImportanceSettingMode",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureImportanceSettingMode, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode.CreateFrom);
            }
            if (content.Contains("FeatureFilterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureFilterType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringFeatureFilterType) content.GetValueForProperty("FeatureFilterType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).FeatureFilterType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringFeatureFilterType.CreateFrom);
            }
            if (content.Contains("ProductionDataColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataColumn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseColumns) content.GetValueForProperty("ProductionDataColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataColumn, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseColumnsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProductionDataContext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataContext = (string) content.GetValueForProperty("ProductionDataContext",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataContext, global::System.Convert.ToString);
            }
            if (content.Contains("ProductionDataInputDataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataInputDataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType) content.GetValueForProperty("ProductionDataInputDataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataInputDataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType.CreateFrom);
            }
            if (content.Contains("ProductionDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("ProductionDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            if (content.Contains("ProductionDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataUri = (string) content.GetValueForProperty("ProductionDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ProductionDataUri, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceDataColumn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataColumn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitoringInputDataBaseColumns) content.GetValueForProperty("ReferenceDataColumn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataColumn, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitoringInputDataBaseColumnsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReferenceDataContext"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataContext = (string) content.GetValueForProperty("ReferenceDataContext",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataContext, global::System.Convert.ToString);
            }
            if (content.Contains("ReferenceDataInputDataType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataInputDataType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType) content.GetValueForProperty("ReferenceDataInputDataType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataInputDataType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitoringInputDataType.CreateFrom);
            }
            if (content.Contains("ReferenceDataJobInputType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataJobInputType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType) content.GetValueForProperty("ReferenceDataJobInputType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataJobInputType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType.CreateFrom);
            }
            if (content.Contains("ReferenceDataUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataUri = (string) content.GetValueForProperty("ReferenceDataUri",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignalInternal)this).ReferenceDataUri, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignal"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignal"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignal DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataDriftMonitoringSignal(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.DataDriftMonitoringSignal"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignal"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignal DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataDriftMonitoringSignal(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataDriftMonitoringSignal" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataDriftMonitoringSignal" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IDataDriftMonitoringSignal FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(DataDriftMonitoringSignalTypeConverter))]
    public partial interface IDataDriftMonitoringSignal

    {

    }
}