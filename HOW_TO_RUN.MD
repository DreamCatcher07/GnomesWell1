# How to Run Gnome on a Rope

## Requirements
- **Unity 2021.3.x (LTS)** or later  
- Windows 10/11 or macOS (8 GB RAM minimum)  
- Disk space: ~1 GB  


---

## Running from Source (Unity Editor)
1. Open **Unity Hub**.  
2. Click **Add Project** and select this repository’s folder.  
3. Once loaded, open the scene:  
   - `Assets/Scenes/Main.scene`  
4. Click the **Play** button at the top of the Unity Editor.  

---

## Running the Built Version
If you don’t want to open Unity:
1. Go to the `/Builds/` folder.  
2. Run the executable:  
   - On Windows: `GnomeOnARope.exe`  
   - On macOS: `GnomeOnARope.app`  

---

## Controls
- **Arrow Keys / A & D** → Move left and right  
- **Up Arrow / W** → Shorten rope  
- **Down Arrow / S** → Lengthen rope  
- **Esc** → Pause menu  

---

## Notes
- The repository includes a **`.gitignore`** file that excludes unnecessary Unity-generated folders (e.g., `Library/`, `Temp/`, `Obj/`).  
  -  Only **Assets/** and **ProjectSettings/** (and optional Builds/) are included, which are enough to open and run the project.  
  - This keeps the repository small and ensures clean version control.  

- If the game does not run smoothly, try lowering the resolution from Unity’s **Game** tab or build settings.  
- Rope physics are CPU-intensive; best performance on systems with 8 GB RAM or more.  
- If you encounter missing assets, ensure the `Assets/` and `ProjectSettings/` folders are intact.  
