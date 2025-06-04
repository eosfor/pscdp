namespace BaristaLabs.ChromeDevTools.Runtime.BluetoothEmulation
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the BluetoothEmulation domain to simplify the command interface.
    /// </summary>
    public class BluetoothEmulationAdapter
    {
        private readonly ChromeSession m_session;
        
        public BluetoothEmulationAdapter(ChromeSession session)
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
        /// Enable the BluetoothEmulation domain.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Set the state of the simulated central.
        /// </summary>
        public async Task<SetSimulatedCentralStateCommandResponse> SetSimulatedCentralState(SetSimulatedCentralStateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetSimulatedCentralStateCommand, SetSimulatedCentralStateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Disable the BluetoothEmulation domain.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command ?? new DisableCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates a peripheral with |address|, |name| and |knownServiceUuids|
        /// that has already been connected to the system.
        /// </summary>
        public async Task<SimulatePreconnectedPeripheralCommandResponse> SimulatePreconnectedPeripheral(SimulatePreconnectedPeripheralCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulatePreconnectedPeripheralCommand, SimulatePreconnectedPeripheralCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates an advertisement packet described in |entry| being received by
        /// the central.
        /// </summary>
        public async Task<SimulateAdvertisementCommandResponse> SimulateAdvertisement(SimulateAdvertisementCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulateAdvertisementCommand, SimulateAdvertisementCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates the response code from the peripheral with |address| for a
        /// GATT operation of |type|. The |code| value follows the HCI Error Codes from
        /// Bluetooth Core Specification Vol 2 Part D 1.3 List Of Error Codes.
        /// </summary>
        public async Task<SimulateGATTOperationResponseCommandResponse> SimulateGATTOperationResponse(SimulateGATTOperationResponseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulateGATTOperationResponseCommand, SimulateGATTOperationResponseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates the response from the characteristic with |characteristicId| for a
        /// characteristic operation of |type|. The |code| value follows the Error
        /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
        /// The |data| is expected to exist when simulating a successful read operation
        /// response.
        /// </summary>
        public async Task<SimulateCharacteristicOperationResponseCommandResponse> SimulateCharacteristicOperationResponse(SimulateCharacteristicOperationResponseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulateCharacteristicOperationResponseCommand, SimulateCharacteristicOperationResponseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates the response from the descriptor with |descriptorId| for a
        /// descriptor operation of |type|. The |code| value follows the Error
        /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
        /// The |data| is expected to exist when simulating a successful read operation
        /// response.
        /// </summary>
        public async Task<SimulateDescriptorOperationResponseCommandResponse> SimulateDescriptorOperationResponse(SimulateDescriptorOperationResponseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulateDescriptorOperationResponseCommand, SimulateDescriptorOperationResponseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Adds a service with |serviceUuid| to the peripheral with |address|.
        /// </summary>
        public async Task<AddServiceCommandResponse> AddService(AddServiceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddServiceCommand, AddServiceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes the service respresented by |serviceId| from the simulated central.
        /// </summary>
        public async Task<RemoveServiceCommandResponse> RemoveService(RemoveServiceCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveServiceCommand, RemoveServiceCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Adds a characteristic with |characteristicUuid| and |properties| to the
        /// service represented by |serviceId|.
        /// </summary>
        public async Task<AddCharacteristicCommandResponse> AddCharacteristic(AddCharacteristicCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddCharacteristicCommand, AddCharacteristicCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes the characteristic respresented by |characteristicId| from the
        /// simulated central.
        /// </summary>
        public async Task<RemoveCharacteristicCommandResponse> RemoveCharacteristic(RemoveCharacteristicCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveCharacteristicCommand, RemoveCharacteristicCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Adds a descriptor with |descriptorUuid| to the characteristic respresented
        /// by |characteristicId|.
        /// </summary>
        public async Task<AddDescriptorCommandResponse> AddDescriptor(AddDescriptorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<AddDescriptorCommand, AddDescriptorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Removes the descriptor with |descriptorId| from the simulated central.
        /// </summary>
        public async Task<RemoveDescriptorCommandResponse> RemoveDescriptor(RemoveDescriptorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<RemoveDescriptorCommand, RemoveDescriptorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Simulates a GATT disconnection from the peripheral with |address|.
        /// </summary>
        public async Task<SimulateGATTDisconnectionCommandResponse> SimulateGATTDisconnection(SimulateGATTDisconnectionCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SimulateGATTDisconnectionCommand, SimulateGATTDisconnectionCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Event for when a GATT operation of |type| to the peripheral with |address|
        /// happened.
        /// </summary>
        public void SubscribeToGattOperationReceivedEvent(Action<GattOperationReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Event for when a characteristic operation of |type| to the characteristic
        /// respresented by |characteristicId| happened. |data| and |writeType| is
        /// expected to exist when |type| is write.
        /// </summary>
        public void SubscribeToCharacteristicOperationReceivedEvent(Action<CharacteristicOperationReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Event for when a descriptor operation of |type| to the descriptor
        /// respresented by |descriptorId| happened. |data| is expected to exist when
        /// |type| is write.
        /// </summary>
        public void SubscribeToDescriptorOperationReceivedEvent(Action<DescriptorOperationReceivedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}