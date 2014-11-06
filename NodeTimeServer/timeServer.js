var http = require('https');
var fs = require('fs');

var options = {
  // key: fs.readFileSync('./ssl/server.key'),
  // cert: fs.readFileSync('./ssl/server.crt'),
  // ca: fs.readFileSync('./ssl/ca.crt'),
  //questCert: true,
  //rejectUnauthorized: false
};

http.createServer(options, function(req, res){
	switch(req.url) {
    case '/update':
      res.writeHead(200, {'Content-Type': 'text/plain'});
	  var now = new Date();
	  var dateString = ("0" + now.getDate()).slice(-2) + '.' + ("0" + (now.getMonth() + 1)).slice(-2) 
	  + '.'+now.getFullYear() + ' ' + ("0" + now.getHours()).slice(-2) + ':' + ("0" + now.getMinutes()).slice(-2) 
	  + ':' + ("0" + now.getSeconds()).slice(-2);	  
      res.write(dateString);
	  res.end();
      break;
	case '/getTime':
	  res.writeHead(200, {'Content-Type': 'text/plain'});
	  date = Date.now();
	  res.write(date.toString());
	  res.end();
	  break;
    default:
      fs.readFile('index.html', function(err, data){
		res.writeHead(200,{
			'Content-Type' : 'text/html',
			'Content-Length' : data.length,
		});
		
		res.write(data);
        res.end();
	});
  };	
}).listen(1337, '127.0.0.1');