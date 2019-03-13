const reportController = require('../controllers/project');

module.exports = (app) => {
    app.get('/', reportController.index);

	app.get('/create/', reportController.createGet);
	app.post('/create/', reportController.createPost);

	app.get('/edit/:id', reportController.editGet);
	app.post('/edit/:id', reportController.editPost);

	app.get('/delete/:id', reportController.deleteGet);
	app.post('/delete/:id', reportController.deletePost);
};