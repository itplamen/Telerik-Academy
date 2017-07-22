var port = 1234;
var http = require('http');
var fs = require('fs');
var formidable = require('formidable');
var uuid = require('node-uuid');
var imageExt = '.jpg';
var uploadForm;

http.createServer(function(req, res) {
    res.writeHeader(200, {
        'Content-Type': 'text/html'
    });

    if (req.url === '/' && req.method.toLocaleLowerCase() === 'get') {
        res.end(uploadForm);
    }

    if (req.url === '/upload' && req.method.toLocaleLowerCase() === 'post') {
        parseFormData(req, res);
        return;
    }

    if (req.url.indexOf('/images') === 0) {
        var imageId = __dirname + req.url;

        fs.readFile(imageId, function(error, data) {
            if (error) {
                console.log('Cannot read image...');
                return;
            }

            res.write('<html><body><img src="data:image/jpeg;base64,');
            res.write(new Buffer(data).toString('base64'));
            res.end('"/></body></html>');
        });

        return;
    }

    function parseFormData(req, res) {
        var form = new formidable.IncomingForm();
        form.parse(req, function (err, fields, files) {
            var filePath = files.upload.path;
            saveFile(filePath, res);
        });
    }

    function saveFile(filePath, res) {
        fs.readFile(filePath, function (err, data) {
            var id = uuid.v1();
            var base64Image = data.toString('base64');
            var decodedImage = new Buffer(base64Image, 'base64');

            fs.writeFile('Images/' + id + imageExt, decodedImage, function (error) {});

            res.write('You can access image at: localhost:' + port + '/images/' + id + imageExt);
            res.end();
        });
    }

    res.end();
}).listen(port);

fs.readFile('index.html', function (err, data) {
    if (err) {
        console.log('Cannot read the upload form file...');
    }

    uploadForm = data;
});

console.log('Server running on port ' + port);