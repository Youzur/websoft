"use strict";

const port = process.env.DBWEBB_PORT || 1337;

// Set upp Express server
const express = require("express");
const app = express();

app.use((req, res, next) => {
    console.info(`Got request on ${req.path} (${req.method}).`);
    next();
});

app.get("/", (req, res) => {
    res.send("Hello World");
});

app.get("/about", (req, res) => {
    res.send("About something");
});

app.listen(port, () => {
    console.info(`Server is listening on port ${port}.`);

    console.info("Available routes are:");
    app._router.stack.forEach((r) => {
        if (r.route && r.route.path) {
            console.info(r.route.path);
        }
    });
});