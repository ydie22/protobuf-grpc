var fs = require('fs');
var invoiceProto = require('./Invoice_pb');
var Invoice= invoiceProto.Invoice;

fs.readFile('C:\\Temp\\Invoice.bin', function (err, data) {
    if (err) throw err;
    var invoice = Invoice.deserializeBinary(data).toObject();
    console.log(invoice);
    
    // let msg1 = CoordinatesFrame.decodeDelimited(data);
    // console.log(msg1);
  
    // let msg2 = CoordinatesFrame.decodeDelimited(data);
    // console.log(msg2);
  });
  