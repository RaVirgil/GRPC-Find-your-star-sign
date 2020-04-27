// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/autumn.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class AutumnSelection
  {
    static readonly string __ServiceName = "AutumnSelection";

    static readonly grpc::Marshaller<global::GrpcServer.AutumnRequest> __Marshaller_AutumnRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.AutumnRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.AutumnResponse> __Marshaller_AutumnResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.AutumnResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.AutumnRequest, global::GrpcServer.AutumnResponse> __Method_AutumnSignSelection = new grpc::Method<global::GrpcServer.AutumnRequest, global::GrpcServer.AutumnResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AutumnSignSelection",
        __Marshaller_AutumnRequest,
        __Marshaller_AutumnResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.AutumnReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for AutumnSelection</summary>
    public partial class AutumnSelectionClient : grpc::ClientBase<AutumnSelectionClient>
    {
      /// <summary>Creates a new client for AutumnSelection</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AutumnSelectionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AutumnSelection that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AutumnSelectionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AutumnSelectionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AutumnSelectionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.AutumnResponse AutumnSignSelection(global::GrpcServer.AutumnRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AutumnSignSelection(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.AutumnResponse AutumnSignSelection(global::GrpcServer.AutumnRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AutumnSignSelection, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.AutumnResponse> AutumnSignSelectionAsync(global::GrpcServer.AutumnRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AutumnSignSelectionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.AutumnResponse> AutumnSignSelectionAsync(global::GrpcServer.AutumnRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AutumnSignSelection, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AutumnSelectionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AutumnSelectionClient(configuration);
      }
    }

  }
}
#endregion
