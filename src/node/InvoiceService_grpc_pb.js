// GENERATED CODE -- DO NOT EDIT!

'use strict';
var grpc = require('grpc');
var InvoiceService_pb = require('./InvoiceService_pb.js');
var google_protobuf_timestamp_pb = require('google-protobuf/google/protobuf/timestamp_pb.js');
var InvoiceV2_pb = require('./InvoiceV2_pb.js');

function serialize_Invoicing_FindInvoiceRequest(arg) {
  if (!(arg instanceof InvoiceService_pb.FindInvoiceRequest)) {
    throw new Error('Expected argument of type Invoicing.FindInvoiceRequest');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_Invoicing_FindInvoiceRequest(buffer_arg) {
  return InvoiceService_pb.FindInvoiceRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_Invoicing_FindInvoiceResponse(arg) {
  if (!(arg instanceof InvoiceService_pb.FindInvoiceResponse)) {
    throw new Error('Expected argument of type Invoicing.FindInvoiceResponse');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_Invoicing_FindInvoiceResponse(buffer_arg) {
  return InvoiceService_pb.FindInvoiceResponse.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_Invoicing_FindInvoicesByDateRequest(arg) {
  if (!(arg instanceof InvoiceService_pb.FindInvoicesByDateRequest)) {
    throw new Error('Expected argument of type Invoicing.FindInvoicesByDateRequest');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_Invoicing_FindInvoicesByDateRequest(buffer_arg) {
  return InvoiceService_pb.FindInvoicesByDateRequest.deserializeBinary(new Uint8Array(buffer_arg));
}

function serialize_Invoicing_FindInvoicesByDateResponse(arg) {
  if (!(arg instanceof InvoiceService_pb.FindInvoicesByDateResponse)) {
    throw new Error('Expected argument of type Invoicing.FindInvoicesByDateResponse');
  }
  return Buffer.from(arg.serializeBinary());
}

function deserialize_Invoicing_FindInvoicesByDateResponse(buffer_arg) {
  return InvoiceService_pb.FindInvoicesByDateResponse.deserializeBinary(new Uint8Array(buffer_arg));
}


var InvoicingServiceService = exports.InvoicingServiceService = {
  findInvoice: {
    path: '/Invoicing.InvoicingService/FindInvoice',
    requestStream: false,
    responseStream: false,
    requestType: InvoiceService_pb.FindInvoiceRequest,
    responseType: InvoiceService_pb.FindInvoiceResponse,
    requestSerialize: serialize_Invoicing_FindInvoiceRequest,
    requestDeserialize: deserialize_Invoicing_FindInvoiceRequest,
    responseSerialize: serialize_Invoicing_FindInvoiceResponse,
    responseDeserialize: deserialize_Invoicing_FindInvoiceResponse,
  },
  findInvoicesByDate: {
    path: '/Invoicing.InvoicingService/FindInvoicesByDate',
    requestStream: false,
    responseStream: true,
    requestType: InvoiceService_pb.FindInvoicesByDateRequest,
    responseType: InvoiceService_pb.FindInvoicesByDateResponse,
    requestSerialize: serialize_Invoicing_FindInvoicesByDateRequest,
    requestDeserialize: deserialize_Invoicing_FindInvoicesByDateRequest,
    responseSerialize: serialize_Invoicing_FindInvoicesByDateResponse,
    responseDeserialize: deserialize_Invoicing_FindInvoicesByDateResponse,
  },
};

exports.InvoicingServiceClient = grpc.makeGenericClientConstructor(InvoicingServiceService);
