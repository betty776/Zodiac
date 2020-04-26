// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ZodiacService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Generated {
  public static partial class ZodiacService
  {
    static readonly string __ServiceName = "ZodiacService";

    static readonly grpc::Marshaller<global::Generated.BirthdayRequest> __Marshaller_BirthdayRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.BirthdayRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Generated.OperationResponse> __Marshaller_OperationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Generated.OperationResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Generated.BirthdayRequest, global::Generated.OperationResponse> __Method_ZodiacSign = new grpc::Method<global::Generated.BirthdayRequest, global::Generated.OperationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ZodiacSign",
        __Marshaller_BirthdayRequest,
        __Marshaller_OperationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Generated.ZodiacServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ZodiacService</summary>
    [grpc::BindServiceMethod(typeof(ZodiacService), "BindService")]
    public abstract partial class ZodiacServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Generated.OperationResponse> ZodiacSign(global::Generated.BirthdayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ZodiacService</summary>
    public partial class ZodiacServiceClient : grpc::ClientBase<ZodiacServiceClient>
    {
      /// <summary>Creates a new client for ZodiacService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZodiacServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZodiacService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZodiacServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZodiacServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZodiacServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Generated.OperationResponse ZodiacSign(global::Generated.BirthdayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ZodiacSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Generated.OperationResponse ZodiacSign(global::Generated.BirthdayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ZodiacSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.OperationResponse> ZodiacSignAsync(global::Generated.BirthdayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ZodiacSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Generated.OperationResponse> ZodiacSignAsync(global::Generated.BirthdayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ZodiacSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZodiacServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZodiacServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ZodiacServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ZodiacSign, serviceImpl.ZodiacSign).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ZodiacServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ZodiacSign, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Generated.BirthdayRequest, global::Generated.OperationResponse>(serviceImpl.ZodiacSign));
    }

  }
}
#endregion
