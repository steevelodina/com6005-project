* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background: #f7f7f7;
    color: #333;
}

/* NAVBAR */
.navbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 15px 20px;
    background: #222;
    color: white;
}
.navbar .logo {
    font-size: 22px;
}
.nav-links {
    list-style: none;
    display: flex;
    gap: 20px;
}
.nav-links a {
    color: white;
    text-decoration: none;
}
.active {
    font-weight: bold;
}

/* Mobile Menu Button */
.menu-btn {
    display: none;
    font-size: 22px;
    background: none;
    border: none;
    color: white;
}

/* HERO SECTION */
.hero {
    padding: 60px 20px;
    text-align: center;
    background: #4a90e2;
    color: white;
}

/* CONTENT */
.content {
    padding: 20px;
    max-width: 800px;
    margin: auto;
}

/* FORMS */
form {
    display: flex;
    flex-direction: column;
    gap: 10px;
}
input, textarea {
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
}
button {
    padding: 10px;
    background: #4a90e2;
    color: white;
    border: none;
    cursor: pointer;
}

/* FOOTER */
footer {
    text-align: center;
    padding: 15px;
    background: #222;
    color: white;
    margin-top: 40px;
}

/* RESPONSIVE NAV */
@media (max-width: 768px) {
    .nav-links {
        display: none;
        flex-direction: column;
        background: #333;
        padding: 10px;
    }
    .menu-btn {
        display: block;
    }
}
