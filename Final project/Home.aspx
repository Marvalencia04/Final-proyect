<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>College Webpage</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f2f2f2;
            display: flex;
            flex-direction: column;
            min-height: 100vh;
        }

        header {
            background-color: #333;
            color: white;
            padding: 15px;
            text-align: center;
        }

        nav {
            background-color: #007bff;
            color: white;
            padding: 10px;
            text-align: center;
        }

        footer {
            background-color: #333;
            color: white;
            padding: 10px;
            text-align: center;
        }

        .container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
            margin: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }

        .column {
            padding: 20px;
            text-align: center;
        }

        .central-column {
            display: flex;
            flex-direction: column;
            justify-content: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <i class="fas fa-university fa-2x"></i> <!-- Font Awesome university icon -->
            <h1>College Name</h1>
        </header>
        <nav>
            <a href="#">Home</a> |
            <a href="#">Courses</a> |
            <a href="#">Admissions</a> |
            <a href="#">Contact</a>
        </nav>
        <div class="container">
            <div class="column">
                <h2>Welcome to University</h2>
                <p>
                    This is the central content of the page. You can add text, images, and other elements here to provide information about the college or display featured content.</p>
                <!-- Replace the image with some text -->
                <section>
                    <p>
                        At [University/College Name], we believe in the power of education to shape the leaders and innovators of
            tomorrow. Nestled in a vibrant community of scholars, our institution is dedicated to fostering
            intellectual curiosity, critical thinking, and a passion for lifelong learning.</p>
                    <p>
                        <strong>Why Choose [University/College Name]?</strong></p>
                    <ol>
                        <li><strong>Academic Excellence:</strong> Our distinguished faculty members are experts in their fields,
                committed to providing a world-class education that challenges and inspires students to reach their
                full potential.</li>
                        <li><strong>Cutting-edge Facilities:</strong> Explore state-of-the-art laboratories, libraries, and
                collaborative spaces designed to enhance your academic experience. We provide the resources you need
                to excel in your studies and research.</li>
                        <li><strong>Global Perspective:</strong> Immerse yourself in a diverse and inclusive community that values
                different perspectives. Our international programs and partnerships offer opportunities for cultural
                exchange and global collaboration.</li>
                        <li><strong>Innovative Programs:</strong> Choose from a wide range of programs and majors designed to meet
                the demands of a rapidly evolving job market. Our curriculum combines traditional knowledge with
                cutting-edge research and practical skills.</li>
                        <li><strong>Student Support:</strong> Your success is our priority. Our dedicated support services,
                including academic advising, career counseling, and wellness programs, ensure that you have the
                assistance you need at every step of your academic journey.</li>
                        <li><strong>Engaging Campus Life:</strong> Beyond the classroom, [University/College Name] offers a vibrant
                campus life. Join student organizations, participate in extracurricular activities, and make lasting
                connections that will enrich your college experience.</li>
                    </ol>
                    <p>
                        Discover the possibilities that await you at [University/College Name]. Whether you're a prospective
            student, a current student, or an alum, we invite you to explore our website and learn more about how
            [University/College Name] is shaping the future through education.</p>
                    <p>
                        <strong>Welcome to a community where passion meets purpose, and learning knows no bounds. Your journey
                starts here.</strong></p>
                    <p>
                        <a href="#">Apply Now</a> | <a href="#">Explore Programs</a> | <a href="#">Schedule a Campus Tour</a></p>
                    <p>
                        <a href="#">Contact Information</a> | <a href="#">Follow Us on Social Media</a></p>
                </section>
            </div>
        </div>
    </form>
    <footer>
        <p>&copy; 2023 College Name. All rights reserved.</p>
    </footer>
</body>
</html>
