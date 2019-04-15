var fs = require('fs');
var invoiceProto = require('./Invoice_pb');
var Invoice= invoiceProto.Invoice;

fs.readFile('C:\\Temp\\InvoiceV2.bin', function (err, data) {
    if (err) throw err;
    var invoice = Invoice.deserializeBinary(data).toObject();
    console.log(invoice);
  });
  