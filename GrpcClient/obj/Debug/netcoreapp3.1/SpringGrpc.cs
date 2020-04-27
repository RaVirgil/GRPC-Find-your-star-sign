// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/spring.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class SpringSelection
  {
    static readonly string __ServiceName = "SpringSelection";

    static readonly grpc::Marshaller<global::GrpcServer.SpringRequest> __Marshaller_SpringRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SpringRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.SpringResponse> __Marshaller_SpringResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.SpringResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.SpringRequest, global::GrpcServer.SpringResponse> __Method_SpringSignSelection = new grpc::Method<global::GrpcServer.SpringRequest, global::GrpcServer.SpringResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SpringSignSelection",
        __Marshaller_SpringRequest,
        __Marshaller_SpringResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.SpringReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for SpringSelection</summary>
    public partial class SpringSelectionClient : grpc::ClientBase<SpringSelectionClient>
    {
      /// <summary>Creates a new client for SpringSelection</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SpringSelectionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SpringSelection that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SpringSelectionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SpringSelectionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SpringSelectionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.SpringResponse SpringSignSelection(global::GrpcServer.SpringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SpringSignSelection(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.SpringResponse SpringSignSelection(global::GrpcServer.SpringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SpringSignSelection, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.SpringResponse> SpringSignSelectionAsync(global::GrpcServer.SpringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SpringSignSelectionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.SpringResponse> SpringSignSelectionAsync(global::GrpcServer.SpringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SpringSignSelection, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SpringSelectionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SpringSelectionClient(configuration);
      }
    }

  }
}
#endregion
