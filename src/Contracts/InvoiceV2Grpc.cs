// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InvoiceV2.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace InvoicingV2 {
  public static partial class InvoicingService
  {
    static readonly string __ServiceName = "Invoicing.InvoicingService";

    static readonly grpc::Marshaller<global::InvoicingV2.FindInvoiceRequest> __Marshaller_Invoicing_FindInvoiceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::InvoicingV2.FindInvoiceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::InvoicingV2.FindInvoiceResponse> __Marshaller_Invoicing_FindInvoiceResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::InvoicingV2.FindInvoiceResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::InvoicingV2.FindInvoicesByDateRequest> __Marshaller_Invoicing_FindInvoicesByDateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::InvoicingV2.FindInvoicesByDateRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::InvoicingV2.FindInvoiceRequest, global::InvoicingV2.FindInvoiceResponse> __Method_FindInvoice = new grpc::Method<global::InvoicingV2.FindInvoiceRequest, global::InvoicingV2.FindInvoiceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FindInvoice",
        __Marshaller_Invoicing_FindInvoiceRequest,
        __Marshaller_Invoicing_FindInvoiceResponse);

    static readonly grpc::Method<global::InvoicingV2.FindInvoicesByDateRequest, global::InvoicingV2.FindInvoicesByDateRequest> __Method_FindInvoicesByDate = new grpc::Method<global::InvoicingV2.FindInvoicesByDateRequest, global::InvoicingV2.FindInvoicesByDateRequest>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "FindInvoicesByDate",
        __Marshaller_Invoicing_FindInvoicesByDateRequest,
        __Marshaller_Invoicing_FindInvoicesByDateRequest);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::InvoicingV2.InvoiceV2Reflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of InvoicingService</summary>
    public abstract partial class InvoicingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::InvoicingV2.FindInvoiceResponse> FindInvoice(global::InvoicingV2.FindInvoiceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task FindInvoicesByDate(global::InvoicingV2.FindInvoicesByDateRequest request, grpc::IServerStreamWriter<global::InvoicingV2.FindInvoicesByDateRequest> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for InvoicingService</summary>
    public partial class InvoicingServiceClient : grpc::ClientBase<InvoicingServiceClient>
    {
      /// <summary>Creates a new client for InvoicingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public InvoicingServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for InvoicingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public InvoicingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected InvoicingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected InvoicingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::InvoicingV2.FindInvoiceResponse FindInvoice(global::InvoicingV2.FindInvoiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindInvoice(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::InvoicingV2.FindInvoiceResponse FindInvoice(global::InvoicingV2.FindInvoiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FindInvoice, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::InvoicingV2.FindInvoiceResponse> FindInvoiceAsync(global::InvoicingV2.FindInvoiceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindInvoiceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::InvoicingV2.FindInvoiceResponse> FindInvoiceAsync(global::InvoicingV2.FindInvoiceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FindInvoice, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::InvoicingV2.FindInvoicesByDateRequest> FindInvoicesByDate(global::InvoicingV2.FindInvoicesByDateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindInvoicesByDate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::InvoicingV2.FindInvoicesByDateRequest> FindInvoicesByDate(global::InvoicingV2.FindInvoicesByDateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_FindInvoicesByDate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override InvoicingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new InvoicingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(InvoicingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FindInvoice, serviceImpl.FindInvoice)
          .AddMethod(__Method_FindInvoicesByDate, serviceImpl.FindInvoicesByDate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, InvoicingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FindInvoice, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::InvoicingV2.FindInvoiceRequest, global::InvoicingV2.FindInvoiceResponse>(serviceImpl.FindInvoice));
      serviceBinder.AddMethod(__Method_FindInvoicesByDate, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::InvoicingV2.FindInvoicesByDateRequest, global::InvoicingV2.FindInvoicesByDateRequest>(serviceImpl.FindInvoicesByDate));
    }

  }
}
#endregion
