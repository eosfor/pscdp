namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Emulation domain to simplify the command interface.
    /// </summary>
    public class EmulationAdapter
    {
        private readonly ChromeSession m_session;
        
        public EmulationAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Tells whether emulation is supported.
        /// </summary>
        public async Task<CanEmulateCommandResponse> CanEmulate(CanEmulateCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanEmulateCommand, CanEmulateCommandResponse>(command ?? new CanEmulateCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overridden device metrics.
        /// </summary>
        public async Task<ClearDeviceMetricsOverrideCommandResponse> ClearDeviceMetricsOverride(ClearDeviceMetricsOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceMetricsOverrideCommand, ClearDeviceMetricsOverrideCommandResponse>(command ?? new ClearDeviceMetricsOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overridden Geolocation Position and Error.
        /// </summary>
        public async Task<ClearGeolocationOverrideCommandResponse> ClearGeolocationOverride(ClearGeolocationOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearGeolocationOverrideCommand, ClearGeolocationOverrideCommandResponse>(command ?? new ClearGeolocationOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that page scale factor is reset to initial values.
        /// </summary>
        public async Task<ResetPageScaleFactorCommandResponse> ResetPageScaleFactor(ResetPageScaleFactorCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResetPageScaleFactorCommand, ResetPageScaleFactorCommandResponse>(command ?? new ResetPageScaleFactorCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables or disables simulating a focused and active page.
        /// </summary>
        public async Task<SetFocusEmulationEnabledCommandResponse> SetFocusEmulationEnabled(SetFocusEmulationEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetFocusEmulationEnabledCommand, SetFocusEmulationEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Automatically render all web contents using a dark theme.
        /// </summary>
        public async Task<SetAutoDarkModeOverrideCommandResponse> SetAutoDarkModeOverride(SetAutoDarkModeOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAutoDarkModeOverrideCommand, SetAutoDarkModeOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables CPU throttling to emulate slow CPUs.
        /// </summary>
        public async Task<SetCPUThrottlingRateCommandResponse> SetCPUThrottlingRate(SetCPUThrottlingRateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCPUThrottlingRateCommand, SetCPUThrottlingRateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets or clears an override of the default background color of the frame. This override is used
        /// if the content does not specify one.
        /// </summary>
        public async Task<SetDefaultBackgroundColorOverrideCommandResponse> SetDefaultBackgroundColorOverride(SetDefaultBackgroundColorOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDefaultBackgroundColorOverrideCommand, SetDefaultBackgroundColorOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the values for env(safe-area-inset-*) and env(safe-area-max-inset-*). Unset values will cause the
        /// respective variables to be undefined, even if previously overridden.
        /// </summary>
        public async Task<SetSafeAreaInsetsOverrideCommandResponse> SetSafeAreaInsetsOverride(SetSafeAreaInsetsOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSafeAreaInsetsOverrideCommand, SetSafeAreaInsetsOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
        /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
        /// query results).
        /// </summary>
        public async Task<SetDeviceMetricsOverrideCommandResponse> SetDeviceMetricsOverride(SetDeviceMetricsOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceMetricsOverrideCommand, SetDeviceMetricsOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Start reporting the given posture value to the Device Posture API.
        /// This override can also be set in setDeviceMetricsOverride().
        /// </summary>
        public async Task<SetDevicePostureOverrideCommandResponse> SetDevicePostureOverride(SetDevicePostureOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDevicePostureOverrideCommand, SetDevicePostureOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears a device posture override set with either setDeviceMetricsOverride()
        /// or setDevicePostureOverride() and starts using posture information from the
        /// platform again.
        /// Does nothing if no override is set.
        /// </summary>
        public async Task<ClearDevicePostureOverrideCommandResponse> ClearDevicePostureOverride(ClearDevicePostureOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDevicePostureOverrideCommand, ClearDevicePostureOverrideCommandResponse>(command ?? new ClearDevicePostureOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Start using the given display features to pupulate the Viewport Segments API.
        /// This override can also be set in setDeviceMetricsOverride().
        /// </summary>
        public async Task<SetDisplayFeaturesOverrideCommandResponse> SetDisplayFeaturesOverride(SetDisplayFeaturesOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDisplayFeaturesOverrideCommand, SetDisplayFeaturesOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the display features override set with either setDeviceMetricsOverride()
        /// or setDisplayFeaturesOverride() and starts using display features from the
        /// platform again.
        /// Does nothing if no override is set.
        /// </summary>
        public async Task<ClearDisplayFeaturesOverrideCommandResponse> ClearDisplayFeaturesOverride(ClearDisplayFeaturesOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDisplayFeaturesOverrideCommand, ClearDisplayFeaturesOverrideCommandResponse>(command ?? new ClearDisplayFeaturesOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setScrollbarsHidden
        /// </summary>
        public async Task<SetScrollbarsHiddenCommandResponse> SetScrollbarsHidden(SetScrollbarsHiddenCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetScrollbarsHiddenCommand, SetScrollbarsHiddenCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setDocumentCookieDisabled
        /// </summary>
        public async Task<SetDocumentCookieDisabledCommandResponse> SetDocumentCookieDisabled(SetDocumentCookieDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDocumentCookieDisabledCommand, SetDocumentCookieDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setEmitTouchEventsForMouse
        /// </summary>
        public async Task<SetEmitTouchEventsForMouseCommandResponse> SetEmitTouchEventsForMouse(SetEmitTouchEventsForMouseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEmitTouchEventsForMouseCommand, SetEmitTouchEventsForMouseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Emulates the given media type or media feature for CSS media queries.
        /// </summary>
        public async Task<SetEmulatedMediaCommandResponse> SetEmulatedMedia(SetEmulatedMediaCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEmulatedMediaCommand, SetEmulatedMediaCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Emulates the given vision deficiency.
        /// </summary>
        public async Task<SetEmulatedVisionDeficiencyCommandResponse> SetEmulatedVisionDeficiency(SetEmulatedVisionDeficiencyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEmulatedVisionDeficiencyCommand, SetEmulatedVisionDeficiencyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting latitude, longitude or
        /// accuracy emulates position unavailable.
        /// </summary>
        public async Task<SetGeolocationOverrideCommandResponse> SetGeolocationOverride(SetGeolocationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetGeolocationOverrideCommand, SetGeolocationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// getOverriddenSensorInformation
        /// </summary>
        public async Task<GetOverriddenSensorInformationCommandResponse> GetOverriddenSensorInformation(GetOverriddenSensorInformationCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetOverriddenSensorInformationCommand, GetOverriddenSensorInformationCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides a platform sensor of a given type. If |enabled| is true, calls to
        /// Sensor.start() will use a virtual sensor as backend rather than fetching
        /// data from a real hardware sensor. Otherwise, existing virtual
        /// sensor-backend Sensor objects will fire an error event and new calls to
        /// Sensor.start() will attempt to use a real sensor instead.
        /// </summary>
        public async Task<SetSensorOverrideEnabledCommandResponse> SetSensorOverrideEnabled(SetSensorOverrideEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSensorOverrideEnabledCommand, SetSensorOverrideEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Updates the sensor readings reported by a sensor type previously overridden
        /// by setSensorOverrideEnabled.
        /// </summary>
        public async Task<SetSensorOverrideReadingsCommandResponse> SetSensorOverrideReadings(SetSensorOverrideReadingsCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSensorOverrideReadingsCommand, SetSensorOverrideReadingsCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides a pressure source of a given type, as used by the Compute
        /// Pressure API, so that updates to PressureObserver.observe() are provided
        /// via setPressureStateOverride instead of being retrieved from
        /// platform-provided telemetry data.
        /// </summary>
        public async Task<SetPressureSourceOverrideEnabledCommandResponse> SetPressureSourceOverrideEnabled(SetPressureSourceOverrideEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPressureSourceOverrideEnabledCommand, SetPressureSourceOverrideEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// TODO: OBSOLETE: To remove when setPressureDataOverride is merged.
        /// Provides a given pressure state that will be processed and eventually be
        /// delivered to PressureObserver users. |source| must have been previously
        /// overridden by setPressureSourceOverrideEnabled.
        /// </summary>
        public async Task<SetPressureStateOverrideCommandResponse> SetPressureStateOverride(SetPressureStateOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPressureStateOverrideCommand, SetPressureStateOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Provides a given pressure data set that will be processed and eventually be
        /// delivered to PressureObserver users. |source| must have been previously
        /// overridden by setPressureSourceOverrideEnabled.
        /// </summary>
        public async Task<SetPressureDataOverrideCommandResponse> SetPressureDataOverride(SetPressureDataOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPressureDataOverrideCommand, SetPressureDataOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the Idle state.
        /// </summary>
        public async Task<SetIdleOverrideCommandResponse> SetIdleOverride(SetIdleOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetIdleOverrideCommand, SetIdleOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears Idle state overrides.
        /// </summary>
        public async Task<ClearIdleOverrideCommandResponse> ClearIdleOverride(ClearIdleOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearIdleOverrideCommand, ClearIdleOverrideCommandResponse>(command ?? new ClearIdleOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides value returned by the javascript navigator object.
        /// </summary>
        public async Task<SetNavigatorOverridesCommandResponse> SetNavigatorOverrides(SetNavigatorOverridesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetNavigatorOverridesCommand, SetNavigatorOverridesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets a specified page scale factor.
        /// </summary>
        public async Task<SetPageScaleFactorCommandResponse> SetPageScaleFactor(SetPageScaleFactorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPageScaleFactorCommand, SetPageScaleFactorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Switches script execution in the page.
        /// </summary>
        public async Task<SetScriptExecutionDisabledCommandResponse> SetScriptExecutionDisabled(SetScriptExecutionDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetScriptExecutionDisabledCommand, SetScriptExecutionDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables touch on platforms which do not support them.
        /// </summary>
        public async Task<SetTouchEmulationEnabledCommandResponse> SetTouchEmulationEnabled(SetTouchEmulationEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTouchEmulationEnabledCommand, SetTouchEmulationEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
        /// the current virtual time policy.  Note this supersedes any previous time budget.
        /// </summary>
        public async Task<SetVirtualTimePolicyCommandResponse> SetVirtualTimePolicy(SetVirtualTimePolicyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetVirtualTimePolicyCommand, SetVirtualTimePolicyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides default host system locale with the specified one.
        /// </summary>
        public async Task<SetLocaleOverrideCommandResponse> SetLocaleOverride(SetLocaleOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetLocaleOverrideCommand, SetLocaleOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides default host system timezone with the specified one.
        /// </summary>
        public async Task<SetTimezoneOverrideCommandResponse> SetTimezoneOverride(SetTimezoneOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTimezoneOverrideCommand, SetTimezoneOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Resizes the frame/viewport of the page. Note that this does not affect the frame's container
        /// (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported
        /// on Android.
        /// </summary>
        public async Task<SetVisibleSizeCommandResponse> SetVisibleSize(SetVisibleSizeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetVisibleSizeCommand, SetVisibleSizeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setDisabledImageTypes
        /// </summary>
        public async Task<SetDisabledImageTypesCommandResponse> SetDisabledImageTypes(SetDisabledImageTypesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDisabledImageTypesCommand, SetDisabledImageTypesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setHardwareConcurrencyOverride
        /// </summary>
        public async Task<SetHardwareConcurrencyOverrideCommandResponse> SetHardwareConcurrencyOverride(SetHardwareConcurrencyOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetHardwareConcurrencyOverrideCommand, SetHardwareConcurrencyOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding user agent with the given string.
        /// `userAgentMetadata` must be set for Client Hint headers to be sent.
        /// </summary>
        public async Task<SetUserAgentOverrideCommandResponse> SetUserAgentOverride(SetUserAgentOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetUserAgentOverrideCommand, SetUserAgentOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding the automation flag.
        /// </summary>
        public async Task<SetAutomationOverrideCommandResponse> SetAutomationOverride(SetAutomationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetAutomationOverrideCommand, SetAutomationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding the difference between the small and large viewport sizes, which determine the
        /// value of the `svh` and `lvh` unit, respectively. Only supported for top-level frames.
        /// </summary>
        public async Task<SetSmallViewportHeightDifferenceOverrideCommandResponse> SetSmallViewportHeightDifferenceOverride(SetSmallViewportHeightDifferenceOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSmallViewportHeightDifferenceOverrideCommand, SetSmallViewportHeightDifferenceOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
        /// </summary>
        public void SubscribeToVirtualTimeBudgetExpiredEvent(Action<VirtualTimeBudgetExpiredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}