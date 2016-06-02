using System;
using Microsoft.Win32;

namespace IMS.WebApp.Tools
{
	public class Registry
	{
		/// <summary>
		/// Function used to write registry keys
		/// </summary>
		/// <param name="rootName"></param>
		/// <param name="keyPathName"></param>
		/// <param name="value"></param>
		/// <returns>true if the writing succeeded, false if the writing failed</returns>
		public static bool RegistryWrite(string rootName, string keyPathName, Object value)
		{
			// Check if keypath and value to be written exist
			if (keyPathName.Length == 0 || value == null)
				return false;

			rootName = "SOFTWARE\\" + rootName;

			try
			{
				// Attempt to open existing registry key
				RegistryKey appKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(rootName, true);

				// If no key exists
				if (appKey == null)
				{
					// Create a new registry key
					appKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(rootName);

					// If registry key creation failed terminate function
					if (appKey == null)
						return false;

					// Open key for writing
					appKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(rootName, true);

					// If the second attemp to open registry key for writing failed terminate function
					if (appKey == null)
						return false;
				}

				// Write the key
				int count = keyPathName.Split('\\').Length;

				if (count > 1)
				{
					int index = 0;

					foreach (string item in keyPathName.Split('\\'))
					{
						index++;

						if (index < count)
						{
							RegistryKey saveKey = appKey;
							appKey = appKey.OpenSubKey(item, true);

							if (appKey == null)
							{
								appKey = saveKey.CreateSubKey(item);

								if (appKey == null)
									return false;
							}
						}
						else
						{
							keyPathName = item;
						}
					}
				}

				appKey.SetValue(keyPathName, value);
			}
			catch (Exception)
			{
				return false;
			}

			// If execution reached this point it means
			// the registry key was successfull written
			return true;
		}

		/// <summary>
		/// Function used to read registry keys
		/// </summary>
		/// <param name="rootName"></param>
		/// <param name="keyPathName"></param>
		/// <returns></returns>
		public static Object RegistryRead(string rootName, string keyPathName)
		{
			// Check if the keypath is not empty
			if (keyPathName.Length == 0)
				return null;

			rootName = "SOFTWARE\\" + rootName;

			RegistryKey appKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(rootName, false);

			if (appKey == null)
				return null;

			int count = keyPathName.Split('\\').Length;

			if (count > 1)
			{
				int index = 0;

				foreach (string item in keyPathName.Split('\\'))
				{
					index++;

					if (index < count)
					{
						appKey = appKey.OpenSubKey(item, false);

						if (appKey == null)
							return null;
					}
					else
					{
						keyPathName = item;
					}
				}
			}

			return appKey.GetValue(keyPathName);
		}

		/// <summary>
		/// Function used to delete entries from registry
		/// </summary>
		/// <param name="rootName"></param>
		/// <param name="keyPathName"></param>
		/// <returns></returns>
		public static bool RegistryDelete(string rootName, string keyPathName)
		{
			if (keyPathName.Length == 0)
				return false;

			rootName = "SOFTWARE\\" + rootName;

			try
			{
				RegistryKey appKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(rootName, true);

				if (appKey == null)
				{
					appKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(rootName);

					if (appKey == null)
						return false;

					appKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(rootName, true);

					if (appKey == null)
						return false;
				}

				int count = keyPathName.Split('\\').Length;

				if (count > 1)
				{
					int index = 0;

					foreach (string item in keyPathName.Split('\\'))
					{
						index++;

						if (index < count)
						{
							RegistryKey deleteKey = appKey;
							appKey = appKey.OpenSubKey(item, true);

							if (appKey == null)
							{
								appKey = deleteKey.CreateSubKey(item);

								if (appKey == null)
									return false;
							}
						}
						else
						{
							keyPathName = item;
						}
					}
				}

				appKey.DeleteSubKey(keyPathName);
			}
			catch
			{
				return false;
			}

			return true;
		}
    }
}
