// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/summer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class SummerSelection
  {
    static readonly string __ServiceName = "SummerSelection";

    static readonly grpc::Marshaller<global::GrpcServer.SummerRequest> __Marshaller_SummerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SummerRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.SummerResponse> __Marshaller_SummerResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SummerResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.SummerRequest, global::GrpcServer.SummerResponse> __Method_SummerSignSelection = new grpc::Method<global::GrpcServer.SummerRequest, global::GrpcServer.SummerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SummerSignSelection",
        __Marshaller_SummerRequest,
        __Marshaller_SummerResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.SummerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SummerSelection</summary>
    [grpc::BindServiceMethod(typeof(SummerSelection), "BindService")]
    public abstract partial class SummerSelectionBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.SummerResponse> SummerSignSelection(global::GrpcServer.SummerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SummerSelectionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SummerSignSelection, serviceImpl.SummerSignSelection).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SummerSelectionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SummerSignSelection, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.SummerRequest, global::GrpcServer.SummerResponse>(serviceImpl.SummerSignSelection));
    }

  }
}
#endregion