var messages = require('./InvoiceService_pb');
var services = require('./InvoiceService_grpc_pb');

var grpc = require('grpc');

var client = new services.InvoicingServiceClient('localhost:55555',
                                        grpc.credentials.createInsecure());
var request = new messages.FindInvoiceRequest();
request.setInvoiceNumber('123456789');
client.findInvoice(request, function(err, response) {
    console.log('Invoice found:', response.getInvoice().getInvoiceNumber());
});
