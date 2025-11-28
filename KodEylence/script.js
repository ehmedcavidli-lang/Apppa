
document.addEventListener('DOMContentLoaded', () => {
    const cards = document.querySelectorAll('.card');
    const overlay = document.getElementById('overlay');
    const overlayImg = document.getElementById('overlayImg');
    const closeBtn = document.getElementById('closeBtn');
  

    function openImage(url, altText) {
      overlayImg.src = url;
      overlayImg.alt = altText || 'Seçilmiş şəkil';
      overlay.classList.add('open');
      overlay.setAttribute('aria-hidden', 'false');
  
     
      closeBtn.focus();
    }
  
  
    function closeOverlay() {
      overlay.classList.remove('open');
      overlay.setAttribute('aria-hidden', 'true');
     
      setTimeout(() => overlayImg.src = '', 200);
    }
  
  
    cards.forEach((card, idx) => {
      card.addEventListener('click', () => {
        const url = card.getAttribute('data-img');
        const alt = card.querySelector('.thumb')?.textContent || `Kart ${idx+1}`;
        if (url) openImage(url.trim(), alt);
      });
  
      
      card.addEventListener('keydown', (ev) => {
        if (ev.key === 'Enter' || ev.key === ' ') {
          ev.preventDefault();
          card.click();
        }
      });
    });
  
   
    overlay.addEventListener('click', (e) => {
      if (e.target === overlay) closeOverlay();
    });
  
  
    closeBtn.addEventListener('click', closeOverlay);
  
 
    document.addEventListener('keydown', (e) => {
      if (e.key === 'Escape' && overlay.classList.contains('open')) closeOverlay();
    });
  });
  