﻿' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IService

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: agregue aquí sus operaciones de servicio

End Interface

' Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean
    <DataMember()>
    Public Property StringValue() As String

End Class
