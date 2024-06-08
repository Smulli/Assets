import LIcon from "../Assets/Img/linkedin_icon.png";
import TIcon from "../Assets/Img/Twitter_icon.png";
//import DIcon from "../Assets/Img/discord_icon.png"

function Footer() {
    return <section>
        <div className="f-content cointainer mt-5" variant="dark">
            <footer className="d-flex justify-content-between align-items-end">
                <blockquote className="m-0 px-3 text-muted"><small>Email: albertmiragamedev@gmail.com || Discord: smulli - Copy Right&copy; 2023 Mira Softworks Lab</small></blockquote>
                <div className="col-2">
                    <a href="https://www.linkedin.com/in/albert-diaz-miravete-351180216/" target="_blank" rel="noopener noreferrer">
                        <img id="socialIcon" className="img-fluid px-1" src={LIcon} height={30} width={30} />
                    </a>
                    <a href="https://twitter.com/MiraSoftworks" target="_blank" rel="noopener noreferrer">
                        <img id="socialIcon" className="img-fluid px-1 mt-1" src={TIcon} height={30} width={30} />
                    </a>
                </div>
            </footer>
        </div>
    </section>
}

export default Footer;