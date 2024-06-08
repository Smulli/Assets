import Header from "./layouts/Header";
import Footer from "./layouts/Footer"
import HomeView from "./Views/HomeView";
import ProjectView from "./Views/ProjectView";
//import GalleryView from "./Views/GalleryView";}
import AboutView from "./Views/AboutView";
import "./Assets/stuff.css";
import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import { Fragment } from "react";
import { Helmet } from "react-helmet";

function App() {
    return (
        <div className="App text-center">
            <BrowserRouter>
                <Helmet>
                    <title>Welcome</title>
                    
                    <meta name="description" content="colorblind games" />
                    <meta name="keywords" content="Web Issues, React, Bootstrap, GitHub, Software, Startup, Game Developing, Technology, Mobile Games, Games Industry, colorblind games, juegos para daltonicos" />
                </Helmet>

                <Routes>
                    <Route path="/" element={<Header />}>
                        <Route index element={<HomeView />} />
                        <Route path="gallery" element={Fragment} />
                        <Route path="projects" element={<ProjectView />} />
                        <Route path="about" element={<AboutView aboutText="Mira Softworks is not only a personal brand, it is what identifies me as a 3D artist and video game developer, so it is also my little corner on the web where I can share everything I learn with you. I hope you have fun exploring my projects and capture my passion for what I do. I work hard to deliver innovative and creative solutions to the challenges that come my way and I'm excited to show you what I've accomplished so far." bioText="Welcome to my portfolio as a 3D developer and modeler. Over the years, I have created high-quality, realistic 3D models for animation, video games, and virtual reality. I also have experience developing applications and interactive spaces. Browse my portfolio to see examples of my mastery in performance, texturing, lighting, and animation. I'm excited that one day you and I can work on future projects and take your ideas to the next level." />} />

                        <Route path="*" element={<Navigate replace to="/" />} />
                    </Route>
                </Routes>
            </BrowserRouter>

            <div>
                <Footer />
            </div>
        </div>
    )
}

export default App;