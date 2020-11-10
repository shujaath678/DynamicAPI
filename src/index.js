const express = require('express');
const app = express();
const port = 8000;
const fs = require('fs');

app.get('/get_meta_data/:module_name/:screen_name', (req, res) => {
    let path = '../specifications/' + req.params.module_name +'/' + req.params.screen_name + '.json';
    fs.readFile(path, 'utf8' , (err, data) => {
        if (err) {
            console.error(err);
            res.status(404).send('Requested file not found.');
        }
        res.status(200).send(JSON.parse(data));
      })
  })




app.listen(port, () => {
    console.log(`Example app listening at http://localhost:${port}`)
  })